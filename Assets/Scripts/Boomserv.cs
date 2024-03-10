using UnityEditor;
using System;
using System.IO;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using UnityEngine;

public class UnityHttpServerEditor
{
    static HttpListener listener;
    //public static string url = "http://localhost:8000/";
    public static string url = "http://*:8000/";
    static Task listenTask;

    //File Sharing Server
    [MenuItem("Boom/Start Server", false, 20)]
    public static void StartServer()
    {
        if (listener == null || !listener.IsListening)
        {
            listener = new HttpListener();
            listener.Prefixes.Add(url);
            listener.Start();
            Debug.Log("Server started. Listening for connections on " + url);

            listenTask = HandleIncomingConnections();
            listenTask.ContinueWith(task =>
            {
                Debug.Log("Server stopped.");
            });
        }
        else
        {
            Debug.LogWarning("Server is already running.");
        }
    }

    [MenuItem("Boom/Stop Server", false, 25)]
    //[MenuItem("Tools/Stop File Sharing Server")]
    public static void StopServer()
    {
        if (listener != null && listener.IsListening)
        {
            listener.Stop();
            listener.Close();
            Debug.Log("Server stopped.");
        }
        else
        {
            Debug.LogWarning("Server is not running.");
        }
    }
    public static async Task HandleIncomingConnections()
    {
        while (listener.IsListening)
        {
            var context = await listener.GetContextAsync();
            var request = context.Request;
            var response = context.Response;

            // Base directory where your levels are stored
            string baseDir = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "Levels";

            // Construct the full file or directory path
            string requestPath = request.Url.AbsolutePath.Replace('/', Path.DirectorySeparatorChar);
            //Path.Combine is weird when asking for full directory view (when the request path is "\"
            //string fullPath = Path.Combine(baseDir, requestPath);
            string fullPath = baseDir + requestPath;

            // Normalize the path to prevent directory traversal
            fullPath = Path.GetFullPath(fullPath);

            // Ensure the requested path is within the base directory
            if (!fullPath.StartsWith(baseDir, StringComparison.OrdinalIgnoreCase))
            {
                Debug.Log("Requested path not in the base directory");
                response.StatusCode = 403; // Forbidden
                response.Close();
                continue;
            }

            // Check if the path is a directory
            if (Directory.Exists(fullPath))
            {
                var directoryInfo = new DirectoryInfo(fullPath);
                var fileInfos = directoryInfo.GetFiles();

                // Generate an HTML page with links to the files
                var sb = new StringBuilder();
                sb.Append("<html><body>");
                sb.AppendFormat("<h2>Files in {0}</h2>", WebUtility.HtmlEncode(requestPath));
                sb.Append("<input type=\"text\" id=\"searchBox\" placeholder=\"Search files...\" onkeyup=\"searchFiles()\">");
                sb.Append("<ul id=\"fileList\">");

                foreach (var fileInfo in fileInfos)
                {
                    //links use the relative path name, don't use .fullName
                    string fileLink = WebUtility.HtmlEncode("/" + fileInfo.Name);
                    sb.AppendFormat("<li><a href=\"{0}\">{1}</a></li>", fileLink, fileInfo.Name);
                }

                //! TODO fix this urgently
                sb.Append("</ul>");
                sb.Append(searchFunctionScript);
                sb.Append("</ul></body></html>");

                byte[] buffer = Encoding.UTF8.GetBytes(sb.ToString());
                response.ContentLength64 = buffer.Length;
                response.ContentType = "text/html";
                await response.OutputStream.WriteAsync(buffer, 0, buffer.Length);
            }
            else if (File.Exists(fullPath))
            {
                // Serve the file (existing logic)
                byte[] bytes = File.ReadAllBytes(fullPath);
                response.ContentType = "application/octet-stream";
                response.ContentLength64 = bytes.Length;
                await response.OutputStream.WriteAsync(bytes, 0, bytes.Length);
            }
            else
            {
                response.StatusCode = 404; // Not Found
            }

            response.Close();
        }
    }

   static string searchFunctionScript = @"
    <script>
    function searchFiles() {
        var input, filter, ul, li, a, i, txtValue;
        input = document.getElementById('searchBox');
        filter = input.value.toUpperCase();
        ul = document.getElementById('fileList');
        li = ul.getElementsByTagName('li');
        for (i = 0; i < li.length; i++) {
            a = li[i].getElementsByTagName('a')[0];
            txtValue = a.textContent || a.innerText;
            if (txtValue.toUpperCase().indexOf(filter) > -1) {
                li[i].style.display = '';
            } else {
                li[i].style.display = 'none';
            }
        }
    }
    </script>
    "; 
}


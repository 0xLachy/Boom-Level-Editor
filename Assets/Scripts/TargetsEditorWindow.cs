using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;
using UnityEditor;
using System.Linq;
using UnityEngine.SceneManagement;

public class TargetsEditorWindow : EditorWindow
{
    //BoomSettings.Refresh()
    //! there is an error where they return nothing!!!
    public static bool singlesCanHaveDescription = BoomSettings.SinglesCanHaveDescription;
    public static bool addSuperStarLevel;

    public static int[] defaultIndexes = BoomSettings.DefaultIndexes;
    public static string[] defaultTargetValues = BoomSettings.DefaultTargetValues;
    public static bool autoDescription = BoomSettings.Autodescription;
    public static string defaultDescription = BoomSettings.DefaultDescription;
    public static int targetListCapacity = BoomSettings.TargetListCapacity;
    public static int _targetListCapacity = targetListCapacity;

    public static string[] targets = { "coin", "ball", "bomb", "rocket", "time", "bowling pin", "boost tunnel", "spring board", "goal", "button", "break ball", "custom", "multiple" };
    public static string[] backgrounds = { "jungle", "city", "ice", "egypt", "festival" };

    public static Color navyBlue = new Color32(48, 81, 99, 39);
    public static Color blueDarkish = new Color32(84, 144, 176, 69);
    public static Color blue = new Color32(109, 186, 227, 89);
    public static Color lightBlue = new Color32(181, 214, 232, 91);
    //TODO: implement a unity color picker in the settings to change these
    //The order you put the colour in the array changes the look
    public static Color[] colorArray = { navyBlue, blueDarkish, blue, lightBlue };

    public List<List<int>> targetIndexesListList = new List<List<int>>(targetListCapacity);
    public List<List<string>> targetValuesListList = new List<List<string>>(targetListCapacity);
    public static Dictionary<int, string> targetDescriptions = new Dictionary<int, string>();


    public string inGameName = "";
    bool showDrWolfenstein = true;
    [SerializeField] Texture2D coin;
    [SerializeField] Texture2D ball;
    [SerializeField] Texture2D bomb;
    [SerializeField] Texture2D rocket;
    [SerializeField] Texture2D bowlingPin;
    [SerializeField] Texture2D springboard;
    [SerializeField] Texture2D boostTunnel;
    [SerializeField] Texture2D goal;
    [SerializeField] Texture2D button;
    [SerializeField] Texture2D breakBall;
    [SerializeField] Texture2D timeImage;
    [SerializeField] public Texture2D drWolfenstein1;
    [SerializeField] Texture2D drWolfenstein2;
    [SerializeField] Texture2D drWolfenstein3;
    Texture2D[] drWolfensteinArr;
    
    //GUIStyle boxStyle;

    static string[] levelsPlistfilters = { "Apple binary", "plist", "All Files", "*" };
    string levelsPlistPath = BoomSettings.DefaultPlistPath;

    static string[] levelsPlhsfilters = { "Boom Level", "plhs", "All Files", "*" };
    string levelPlhsPath;
    static void Init()
    {
        TargetsEditorWindow window = ScriptableObject.CreateInstance<TargetsEditorWindow>();
        window.position = new Rect(Screen.width / 2, Screen.height / 2, 300, 200);
        window.ShowPopup();
    }

    void OnGUI()
    {
        //singlesCanHaveDescription = BoomSettings.SinglesCanHaveDescription;
        //defaultIndexes = BoomSettings.DefaultIndexes;
        //defaultTargetValues = BoomSettings.DefaultTargetValues;
        //autoDescription = BoomSettings.Autodescription;
        //defaultDescription = BoomSettings.DefaultDescription;
        //targetListCapacity = BoomSettings.TargetListCapacity;
        //boxStyle = new GUIStyle(GUI.skin.box);
        //boxStyle.normal.textColor = Color.cyan;
        EditorGUILayout.LabelField("Click the buttons to change the type of target, or to get the file location, " +
            "the box to the right holds how the target will be added. Type 0 or none if no touching, type all for touch/collect/explode " +
            "all, any number for targets, eg 4", EditorStyles.wordWrappedLabel);
        GUILayout.Space(10);

        if (GUILayout.Button("Open Settings"))
        {
            BoomSettings.shouldfocus = true;
            SettingsService.OpenProjectSettings("Project/BoomSettings");
            Close();
            //var window = SettingsService.OpenProjectSettings("Project/BoomSettings");
            //window.Show();
            //EditorUtility.FocusProjectWindow();
            //EditorApplication.ExecuteMenuItem("Edit/Project Settings/");
            //ProjectWindowUtil projectWindowUtil = (Settin)EditorWindow.GetWindow(typeof(ProjectWindowUtil), false, "Gib Halp Plis");
            //BoomSettingsRegister.CreateSettingsProvider();
        }
        EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("Levels.plist (File)"))
        {
            levelsPlistPath = EditorUtility.OpenFilePanelWithFilters("levels.plist should be found in boom.app", "", levelsPlistfilters);
        }
        levelsPlistPath = EditorGUILayout.TextField(levelsPlistPath);
        EditorGUILayout.EndHorizontal();

        //GUILayout.Space(5);

        EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("New Level (File)"))
        {
            levelPlhsPath = EditorUtility.OpenFilePanelWithFilters("levels.plist should be found in boom.app", "", levelsPlhsfilters);
            //add function / code here to get the previous challenges and display them automatically by the name
        }
        levelPlhsPath = EditorGUILayout.TextField(levelPlhsPath);
        EditorGUILayout.EndHorizontal();

        GUILayout.Space(20);

        EditorGUILayout.BeginHorizontal();
        GUILayout.Label("in-game name", GUILayout.MaxWidth((float)(position.width / 8.2)));
        inGameName = GUILayout.TextField(inGameName);
        BoomSettings.DefaultBGIndex = EditorGUILayout.Popup(BoomSettings.DefaultBGIndex, backgrounds, GUILayout.MaxWidth(position.width / 2));
        GUILayout.EndHorizontal();

        GUILayout.Space(10);
        //f*ck unity not having a way to display the text on the right side!!!!
        addSuperStarLevel = GUILayout.Toggle(addSuperStarLevel, "Have Super Star Challenge");
        if (addSuperStarLevel) 
        {
            targetListCapacity = _targetListCapacity + 1; 
        }
        else
        {
            targetListCapacity = _targetListCapacity;
            if(targetIndexesListList.Count > targetListCapacity)
            {
                for (int i = 0; i < targetIndexesListList[targetListCapacity].Count; i++)
                {
                    DecrementLists(targetListCapacity, i);
                }
            }
        }
        GUILayout.Space(20);

        ShowAndEditTargetsInGUI();

        if(showDrWolfenstein)
            ShowDrWolfenstein();

        if (GUILayout.Button("Add to plist"))
        {
            bool answer = false;
            string customLevelName = "";
            if (levelsPlistPath.Length != 0 && levelPlhsPath.Length != 0)
            {
                customLevelName = Path.GetFileNameWithoutExtension(levelPlhsPath);
                //Makes it safer to add the level,
                if (customLevelName.Length < 7 || customLevelName.Substring(0, 7) != "Custom_")
                {
                    answer = EditorUtility.DisplayDialog("WARNING", $"the level \"{customLevelName}\" doesn't contain \"Custom_\" at the start of the name, " +
                        $"press ok if you are sure", "back", "OK");
                    if (answer)
                    {
                        levelPlhsPath = "";
                    }
                }
                string snakeCaseName = string.Concat(customLevelName.Select((x, i) => i > 0 && char.IsUpper(x) ? "_" + x.ToString() : x.ToString()));
                snakeCaseName = snakeCaseName.Replace("__", "_");
                if (customLevelName != snakeCaseName)
                {
                    answer = EditorUtility.DisplayDialog("WARNING", $"the name you chose \"{customLevelName}\" isn't in snake case, an example of how to name it is '{snakeCaseName}", "back", "continue");
                }

            }
            else
            {
                answer = true;
                Debug.LogError("invalid path");
            }
            if (!answer)
            {
                
                BoomSettings.DefaultPlistPath = levelsPlistPath;
                AddLevelToBoomIPA.AddToIpa(targets, targetIndexesListList, targetValuesListList, targetDescriptions, levelsPlistPath, levelPlhsPath, customLevelName, 
                    inGameName, GetBackgroundName());
                Close();
            }
        }
        GUILayout.BeginHorizontal();
        for (int i2 = 0; i2 < targetIndexesListList.Count; i2++)
        {
            //List<int> listInt = targetIndexesListList[i2];
            GUILayout.BeginVertical();
            for (int i1 = 0; i1 < targetIndexesListList[i2].Count; i1++)
            {
                //int i = listInt[i1];
                switch (targets[targetIndexesListList[i2][i1]])
                {
                    case "coin":
                        GUILayout.Box(coin, GUILayout.ExpandHeight(true), GUILayout.MinWidth(position.width / 3), GUILayout.MaxWidth(position.width / 3));
                        break;
                    case "ball":
                        GUILayout.Box(ball, GUILayout.ExpandHeight(true), GUILayout.MinWidth(position.width / 3), GUILayout.MaxWidth(position.width / 3));
                        break;
                    case "bomb":
                        GUILayout.Box(bomb, GUILayout.ExpandHeight(true), GUILayout.MinWidth(position.width / 3), GUILayout.MaxWidth(position.width / 3));
                        break;
                    case "rocket":
                        GUILayout.Box(rocket, GUILayout.ExpandHeight(true), GUILayout.MinWidth(position.width / 3), GUILayout.MaxWidth(position.width / 3));
                        break;
                    case "time":
                        GUILayout.Box(timeImage, GUILayout.ExpandHeight(true), GUILayout.MinWidth(position.width / 3), GUILayout.MaxWidth(position.width / 3));
                        break;
                    case "bowling pin":
                        GUILayout.Box(bowlingPin, GUILayout.ExpandHeight(true), GUILayout.MinWidth(position.width / 3), GUILayout.MaxWidth(position.width / 3));
                        break;
                    case "boost tunnel":
                        GUILayout.Box(boostTunnel, GUILayout.ExpandHeight(true), GUILayout.MinWidth(position.width / 3), GUILayout.MaxWidth(position.width / 3));
                        break;
                    case "spring board":
                        GUILayout.Box(springboard, GUILayout.ExpandHeight(true), GUILayout.MinWidth(position.width / 3), GUILayout.MaxWidth(position.width / 3));
                        break;
                    case "goal":
                        GUILayout.Box(goal, GUILayout.ExpandHeight(true), GUILayout.MinWidth(position.width / 3), GUILayout.MaxWidth(position.width / 3));
                        break;
                    case "button":
                        GUILayout.Box(button, GUILayout.ExpandHeight(true), GUILayout.MinWidth(position.width / 3), GUILayout.MaxWidth(position.width / 3));
                        break;
                    case "break ball":
                        GUILayout.Box(breakBall, GUILayout.ExpandHeight(true), GUILayout.MinWidth(position.width / 3), GUILayout.MaxWidth(position.width / 3));
                        break;
                    case "custom":
                        GUILayout.Box(drWolfenstein1, GUILayout.ExpandHeight(true), GUILayout.MinWidth(position.width / 3), GUILayout.MaxWidth(position.width / 3));
                        break;
                    default:
                        Debug.Log(targets[targetIndexesListList[i2][i1]] + " can't been found in the logo images");
                        break;
                }
            }
            GUILayout.EndVertical();
        }  
    }

    private void ShowAndEditTargetsInGUI()
    {
        //Color defaultColor = GUI.color;
        for (int i = 0; i < targetListCapacity; i++)
        {
            //List<int> intList = targetIndexesListList[i];
            if (targetIndexesListList.Count < i + 1)
            {
                targetIndexesListList.Add(new List<int>(1));
                targetValuesListList.Add(new List<string>(1));
                IncrementLists(i, 0);
            }
            else
            {
                
                if (targetIndexesListList[i].Count > 1)
                {
                    //GUI.color = colorArray[i];
                    EditorGUILayout.BeginVertical();
                    for (int i1 = 0; i1 < targetIndexesListList[i].Count; i1++)
                    {
                        //int entry = targetIndexesListList[i][i1];
                        EditorGUILayout.BeginHorizontal();
                        targetIndexesListList[i][i1] = EditorGUILayout.Popup(targetIndexesListList[i][i1], targets);
                        targetValuesListList[i][i1] = EditorGUILayout.TextField(targetValuesListList[i][i1]);
                        DisplayMultipleButton(i, i1);
                        EditorGUILayout.EndHorizontal();
                    }
                    ManageTargetDescription(i);
                    EditorGUILayout.EndVertical();
                    //GUI.color = defaultColor;
                }
                else
                {
                    EditorGUILayout.BeginHorizontal(); 
                    targetIndexesListList[i][0] = EditorGUILayout.Popup(targetIndexesListList[i][0], targets);
                    targetValuesListList[i][0] = EditorGUILayout.TextField(targetValuesListList[i][0]);
                    DisplayMultipleButton(i, 0);
                    EditorGUILayout.EndHorizontal();
                    if (singlesCanHaveDescription) ManageTargetDescription(i);
                }
                
                if (i != targetIndexesListList.Count - 1)
                    GUILayout.Space(10);
            }
        }
    }

    private void ManageTargetDescription(int i)
    {
        EditorGUILayout.BeginHorizontal();
        if (!targetDescriptions.ContainsKey(i))
        {
            if (GUILayout.Button("Add Description"))
            {
                if (autoDescription)
                {
                    defaultDescription = "";
                    for (int i1 = 0; i1 < targetIndexesListList[i].Count; i1++)
                    {
                        int i2 = targetIndexesListList[i][i1];
                        string targetName = targets[i2];
                        string value = targetValuesListList[i][i1];

                        if (i1 == targetIndexesListList[i].Count - 1)
                        {
                            if(targetName == "time")
                            {
                                defaultDescription = defaultDescription.Remove(defaultDescription.LastIndexOf("and"), 4);
                                defaultDescription += $"within {String.Format("{0:00.000}", float.Parse(value))}";
                            }
                            else if(targetName == "custom")
                            {
                                defaultDescription += $"{value}";
                            }
                            else
                            {
                                defaultDescription += $"{value} {targetName}";
                            }
                        }
                        else
                        {
                            if(value.ToLower() == "all" || int.TryParse(value, out int intValue))
                            {                               
                                if(value.ToLower() == "all" || int.Parse(value) > 1)
                                    defaultDescription += $"{value} {targetName}s and ";
                                else
                                    defaultDescription += $"{value} {targetName} and ";
                            }
                            else if (targetName == "custom")
                            {
                                defaultDescription += $"{value} and "; 
                            }
                            else
                            {
                                defaultDescription += $"{value} {targetName} and ";
                            }
                        }
                    }
                }
                targetDescriptions.Add(i, defaultDescription);
            }
        }
        else
        {
            targetDescriptions[i] = EditorGUILayout.TextField(targetDescriptions[i]);
            if (GUILayout.Button("-"))
            {
                targetDescriptions.Remove(i);
            }
        }
        EditorGUILayout.EndHorizontal();
    }

    private void IncrementLists(int i, int addIndex)
    {
        // increase the capacity if it is too small
        //targetIndexesListList.Capacity = i > targetIndexesListList.Capacity ? i : targetIndexesListList.Capacity;
        if (targetIndexesListList[i] == null)
        {
            targetIndexesListList[i] = new List<int>();
        }
        if(targetIndexesListList[i].Count > addIndex)
        {
            targetIndexesListList[i].Insert(addIndex + 1, defaultIndexes[i]);
            targetValuesListList[i].Insert(addIndex + 1, defaultTargetValues[i]);
        }
        else
        {
            targetIndexesListList[i].Insert(addIndex, defaultIndexes[i]);
            targetValuesListList[i].Insert(addIndex, defaultTargetValues[i]);
        }
    }
    private void DecrementLists(int i, int removalIndex)
    {
        if (targetIndexesListList[i].Count > 1)
        {
            targetIndexesListList[i].RemoveAt(removalIndex);
            targetValuesListList[i].RemoveAt(removalIndex);
        }
    }

    private void DisplayMultipleButton(int listIndex, int addRemoveIndex)
    {
        if(GUILayout.Button("+"))
        {
            IncrementLists(listIndex, addRemoveIndex);
        }
        if (GUILayout.Button("-"))
        {
            DecrementLists(listIndex, addRemoveIndex);
        }
    }

    private void ShowDrWolfenstein()
    {
        if (!drWolfenstein1)
        {
            Debug.LogError("Missing texture, assign a texture in the inspector");
        }
        int thingsInCommon = 0;
        for(int i = 1; i < targetIndexesListList.Count; i++)
        {
            //lazy approach
            if(targetIndexesListList[i][0] == targetIndexesListList[0][0])
            {
                if(targetValuesListList[i].Count == targetValuesListList[0].Count)
                {
                    if (targetValuesListList[i][0] == targetValuesListList[0][0])
                    {
                        thingsInCommon++;
                    }
                }
            }           
        }
        //I hate having to do it like this but I can't get an array in the inspector, and I also can't declare it at the start either
        if(drWolfensteinArr == null)
        {
            drWolfensteinArr = new Texture2D[] { drWolfenstein3, drWolfenstein2, drWolfenstein1 };
        }
        if(thingsInCommon < drWolfensteinArr.Length)
        {
            GUILayout.Box(drWolfensteinArr[thingsInCommon], GUILayout.ExpandHeight(false), GUILayout.ExpandWidth(true));
        }
    }

    string GetBackgroundName()
    {
        return backgrounds[BoomSettings.DefaultBGIndex] switch
        {
            "jungle" => "JungleBG.plist",
            "city" => "CityBG.plist",
            "ice" => "NorthBG.plist",
            "egypt" => "EgyptBG.plist",
            "festival" => "FestivalParkBG.plist",
            _ => "CityBG.plist",
        };
    }
    [MenuItem("Boom/Add To ipa", false, 50)]
    public static void CreateTargetsEditorWindow()
    {
        //BoomSettings.Refresh(ScriptableObject.CreateInstance<BoomSettings>());
        //BoomSettings.Refresh(AssetDatabase.LoadAssetAtPath<BoomSettings>(BoomSettingsRegister.SettingsPath));
        var settings = BoomSettingsRegister.Load();
        BoomSettings.Refresh(settings);
        TargetsEditorWindow window = ScriptableObject.CreateInstance<TargetsEditorWindow>();
        window.ShowUtility();
    }
}

using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;
using UnityEditor;

public class TargetsEditorWindow : EditorWindow
{
    //use none or no, if you think it fits, eg, coins, do none, springboards do 0;
    //if you add 4, then the 4th is a star point thing
    //add complete without left button or right button, break balls
    //add section to add description
    //No plastic, No clouds etc...
    public static int defaultIndex = 0;
    public static string defaultValue = "1";
    public static int targetsCount = 3;
    public static string[] targets = { "coin", "ball", "bomb", "rocket", "time", "bowling pin", "boost tunnel", "spring board", "goal", "button", "break ball", "custom", "multiple" };
    public static string[] backgrounds = { "jungle", "city", "ice", "egypt", "desert", "festival" };
    public static int backgroundIndex = 0;
 //   public int[] targetIndexes = new int[3];
    public int[][] jaggedTargetIndexsArray = new int[targetsCount][];
    public List<List<int>> targetIndexesListList = new List<List<int>>(3);
    public List<List<string>> targetValuesListList = new List<List<string>>(3);
    public List<Dictionary<int, string>> targetValuesDictionaryArray = new List<Dictionary<int, string>>(targetsCount);
    public string[] targetValues = { "1", "1", "1" };
    public string newLevelName = "";
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
    [SerializeField] Texture2D drWolfenstein1;
    [SerializeField] Texture2D drWolfenstein2;
    [SerializeField] Texture2D drWolfenstein3;
    [SerializeField] int groupedTargetLimit = 6;

    static string[] levelsPlistfilters = { "Apple binary", "plist", "All Files", "*" };
    string levelsPlistPath;

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
        EditorGUILayout.LabelField("Click the buttons to change the type of target, or to get the file location, " +
            "the box to the right holds how the target will be added. Type 0 or none if no touching, type all for touch/collect/explode " +
            "all, any number for targets, eg 4", EditorStyles.wordWrappedLabel);
        GUILayout.Space(10);
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
        }
        levelPlhsPath = EditorGUILayout.TextField(levelPlhsPath);
        EditorGUILayout.EndHorizontal();

        GUILayout.Space(20);

        //EditorGUILayout.BeginHorizontal();
        //GUILayout.FlexibleSpace();
        //EditorGUILayout.LabelField("Choose Level background and Name (in game)", EditorStyles.wordWrappedLabel);
        //GUILayout.FlexibleSpace();
        //EditorGUILayout.EndHorizontal();

        EditorGUILayout.BeginHorizontal();
        GUILayout.Label("Level Name", GUILayout.MaxWidth(position.width / 9));
        newLevelName = GUILayout.TextField(newLevelName);
        backgroundIndex = EditorGUILayout.Popup(backgroundIndex, backgrounds);
        GUILayout.EndHorizontal();

        GUILayout.Space(20);

        ShowAndEditTargetsInGUI();
        //ShowAndEditTargetInGUI(0);

        //GUILayout.Space(7);

        //ShowAndEditTargetInGUI(1);

        //GUILayout.Space(7);

        //ShowAndEditTargetInGUI(2);

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
                string camelCaseName = CamelCase(customLevelName);
                if(camelCaseName == customLevelName)
                {
                    answer = EditorUtility.DisplayDialog("WARNING", $"the name you chose \"{customLevelName}\" is in camelCase, the naming convention in boom" +
                            $"files is generally Title Case Snake_Case for the name, if you don't care press continue", "back", "continue");
                }
                Debug.Log(Char.ToUpper(camelCaseName[0]) + camelCaseName.Substring(1));
                

            }
            else
            {
                answer = true;
                Debug.LogError("invalid path");
            }
            if (!answer)
            {
                //AddLevelToBoomIPA.AddToIpa(targets, jaggedTargetIndexsArray, targetValuesDictionaryArray, levelsPlistPath, levelPlhsPath, customLevelName);
                Close();
            }
        }
        //GUILayout.BeginHorizontal();
        //for (int i = 0; i < jaggedTargetIndexsArray.Length; i++)
        //{
        //    //int index = jaggedTargetsArray[i];
        //    switch (targets[jaggedTargetIndexsArray[i][0]])
        //    {
        //        case "coin":
        //            GUILayout.Box(coin, GUILayout.ExpandHeight(true), GUILayout.MinWidth(position.width / 3), GUILayout.MaxWidth(position.width / 3));
        //            break;
        //        case "ball":
        //            GUILayout.Box(ball, GUILayout.ExpandHeight(true), GUILayout.MinWidth(position.width / 3), GUILayout.MaxWidth(position.width / 3));
        //            break;
        //        case "bomb":
        //            GUILayout.Box(bomb, GUILayout.ExpandHeight(true), GUILayout.MinWidth(position.width / 3), GUILayout.MaxWidth(position.width / 3));
        //            break;
        //        case "rocket":
        //            GUILayout.Box(rocket, GUILayout.ExpandHeight(true), GUILayout.MinWidth(position.width / 3), GUILayout.MaxWidth(position.width / 3));
        //            break;
        //        case "time":
        //            GUILayout.Box(timeImage, GUILayout.ExpandHeight(true), GUILayout.MinWidth(position.width / 3), GUILayout.MaxWidth(position.width / 3));
        //            break;
        //        case "bowling pin":
        //            GUILayout.Box(bowlingPin, GUILayout.ExpandHeight(true), GUILayout.MinWidth(position.width / 3), GUILayout.MaxWidth(position.width / 3));
        //            break;
        //        case "boost tunnel":
        //            GUILayout.Box(boostTunnel, GUILayout.ExpandHeight(true), GUILayout.MinWidth(position.width / 3), GUILayout.MaxWidth(position.width / 3));
        //            break;
        //        case "spring board":
        //            GUILayout.Box(springboard, GUILayout.ExpandHeight(true), GUILayout.MinWidth(position.width / 3), GUILayout.MaxWidth(position.width / 3));
        //            break;
        //        case "goal":
        //            GUILayout.Box(goal, GUILayout.ExpandHeight(true), GUILayout.MinWidth(position.width / 3), GUILayout.MaxWidth(position.width / 3));
        //            break;
        //        case "button":
        //            GUILayout.Box(button, GUILayout.ExpandHeight(true), GUILayout.MinWidth(position.width / 3), GUILayout.MaxWidth(position.width / 3));
        //            break;
        //        case "break ball":
        //            GUILayout.Box(breakBall, GUILayout.ExpandHeight(true), GUILayout.MinWidth(position.width / 3), GUILayout.MaxWidth(position.width / 3));
        //            break;
        //        case "custom":
        //            GUILayout.Box(drWolfenstein1, GUILayout.ExpandHeight(true), GUILayout.MinWidth(position.width / 3), GUILayout.MaxWidth(position.width / 3));
        //            break;
        //        case "multiple":
        //            GUILayout.BeginVertical();
        //            //GUILayout.BeginArea(new Rect(494.00f, 337.00f, 249.00f, 234.00f)); doesn't work
        //            //(x: 494.00, y: 337.00, width: 249.00, height: 234.00) after for loop
        //            for (int i1 = 0; i1 < targetValues[i].Length + 1; i1++)
        //            {
        //                int imageIndex = jaggedTargetIndexsArray[i][i1];
        //                switch (targets[imageIndex])
        //                {
        //                    case "coin":
        //                        GUILayout.Box(coin, GUILayout.ExpandHeight(true), GUILayout.MinWidth(position.width / 3), GUILayout.MaxWidth(position.width / 3));
        //                        break;
        //                    case "ball":
        //                        //GUILayout.Box(ball, GUILayout.ExpandHeight(true), GUILayout.ExpandWidth(true));
        //                        GUILayout.Box(ball, GUILayout.MinWidth(position.width / 3), GUILayout.MaxWidth(position.width / 3));
        //                        break;
        //                    case "bomb":
        //                        GUILayout.Box(bomb, GUILayout.ExpandHeight(true), GUILayout.MinWidth(position.width / 3), GUILayout.MaxWidth(position.width / 3));
        //                        break;
        //                    case "rocket":
        //                        GUILayout.Box(rocket, GUILayout.ExpandHeight(true), GUILayout.MinWidth(position.width / 3), GUILayout.MaxWidth(position.width / 3));
        //                        break;
        //                    case "time":
        //                        GUILayout.Box(timeImage, GUILayout.ExpandHeight(true), GUILayout.MinWidth(position.width / 3), GUILayout.MaxWidth(position.width / 3));
        //                        break;
        //                    case "bowling pin":
        //                        GUILayout.Box(bowlingPin, GUILayout.ExpandHeight(true), GUILayout.MinWidth(position.width / 3), GUILayout.MaxWidth(position.width / 3));
        //                        break;
        //                    case "boost tunnel":
        //                        GUILayout.Box(boostTunnel, GUILayout.ExpandHeight(true), GUILayout.MinWidth(position.width / 3), GUILayout.MaxWidth(position.width / 3));
        //                        break;
        //                    case "spring board":
        //                        GUILayout.Box(springboard, GUILayout.ExpandHeight(true), GUILayout.MinWidth(position.width / 3), GUILayout.MaxWidth(position.width / 3));
        //                        break;
        //                    case "goal":
        //                        GUILayout.Box(goal, GUILayout.ExpandHeight(true), GUILayout.MinWidth(position.width / 3), GUILayout.MaxWidth(position.width / 3));
        //                        break;
        //                    case "button":
        //                        GUILayout.Box(goal, GUILayout.ExpandHeight(true), GUILayout.MinWidth(position.width / 3), GUILayout.MaxWidth(position.width / 3));
        //                        break;
        //                    case "break ball":
        //                        GUILayout.Box(breakBall, GUILayout.ExpandHeight(true), GUILayout.MinWidth(position.width / 3), GUILayout.MaxWidth(position.width / 3));
        //                        break;
        //                    case "custom":
        //                        GUILayout.Box(drWolfenstein1, GUILayout.ExpandHeight(true), GUILayout.MinWidth(position.width / 3), GUILayout.MaxWidth(position.width / 3));
        //                        break;
        //                    default:
        //                        Debug.Log(targets[imageIndex] + " can't been found in the logo images");
        //                        break;
        //                }
        //            }
        //            GUILayout.EndVertical();
        //            //using the get last rect, I can figure otu the size of the box in the bottom left, then I can use division by the amount of multiples chosen and bam!
        //            Debug.Log(GUILayoutUtility.GetLastRect());
        //            break;
        //        default:
        //            Debug.Log(targets[i] + " can't been found in the logo images");
        //            break;
        //    }
        //}
        //(x: 494.00, y: 337.00, width: 249.00, height: 234.00) after for loop
    }

    private void ShowAndEditTargetsInGUI()
    {
        for (int i = 0; i < targetIndexesListList.Capacity; i++)
        {
            //List<int> intList = targetIndexesListList[i];
            if (targetIndexesListList.Count < i + 1)
            {
                targetIndexesListList.Add(new List<int>(defaultIndex));
                targetValuesListList.Add(new List<string>(1));
                IncrementLists(i);
            }
            else
            {
                EditorGUILayout.BeginHorizontal();
                if (targetIndexesListList[i].Count > 1)
                {
                   foreach(int entry in targetIndexesListList[i])
                    {
                        targetIndexesListList[i][entry] = EditorGUILayout.Popup(targetIndexesListList[i][entry], targets);
                        targetValuesListList[i][entry] = EditorGUILayout.TextField(targetValuesListList[i][entry]);
                        DisplayMultipleButton(i, entry);
                    }
                }
                else
                {

                    targetIndexesListList[i][0] = EditorGUILayout.Popup(targetIndexesListList[i][0], targets);
                    targetValuesListList[i][0] = EditorGUILayout.TextField(targetValuesListList[i][0]);
                    DisplayMultipleButton(i, 0);
                }
                EditorGUILayout.EndHorizontal();
                if (i != targetIndexesListList.Capacity - 1)
                    GUILayout.Space(10);
            }
        }
    }

    private void IncrementLists(int i)
    {
        targetIndexesListList[i].Add(defaultIndex);
        targetValuesListList[i].Add(defaultValue);
    }
    private void DecrementLists(int i, int removalIndex)
    {
        targetIndexesListList[i].RemoveAt(removalIndex);
        targetValuesListList[i].RemoveAt(removalIndex);
    }

    private void DisplayMultipleButton(int listIndex, int removalIndex)
    {
        if(GUILayout.Button("+"))
        {
            IncrementLists(listIndex);
        }
        if (GUILayout.Button("-"))
        {
            DecrementLists(listIndex, removalIndex);
        }
    }

    private void ShowDrWolfenstein()
    {
        if (!drWolfenstein1)
        {
            Debug.LogError("Missing texture, assign a texture in the inspector");
        }

        //targetValue1 != targetIndex2 || targetIndex2 != targetIndex3 || targetIndex1 != targetIndex3)
        if (jaggedTargetIndexsArray[0] != jaggedTargetIndexsArray[1] || jaggedTargetIndexsArray[1] != jaggedTargetIndexsArray[2] || jaggedTargetIndexsArray[0] != jaggedTargetIndexsArray[2])
        {
            if (jaggedTargetIndexsArray[0] != jaggedTargetIndexsArray[1] && jaggedTargetIndexsArray[2] != jaggedTargetIndexsArray[1] && jaggedTargetIndexsArray[0] != jaggedTargetIndexsArray[2])
            {
                GUILayout.Box(drWolfenstein3, GUILayout.ExpandHeight(false), GUILayout.ExpandWidth(true));
            }
            else if ((jaggedTargetIndexsArray[0] == jaggedTargetIndexsArray[1] && targetValues[0] != targetValues[1]) || (jaggedTargetIndexsArray[1] == jaggedTargetIndexsArray[2] && targetValues[1] != targetValues[2])
                || (jaggedTargetIndexsArray[0] == jaggedTargetIndexsArray[2] && targetValues[0] != targetValues[2]))
            {
                GUILayout.Box(drWolfenstein3, GUILayout.ExpandHeight(false), GUILayout.ExpandWidth(true));
            }
            else
            {
                GUILayout.Box(drWolfenstein2, GUILayout.ExpandHeight(false), GUILayout.ExpandWidth(true));
            }
        }
        else
        {
            if (targetValues[0] != targetValues[1] || targetValues[1] != targetValues[2] || targetValues[0] != targetValues[2])
            {
                if (targetValues[0] != targetValues[1] && targetValues[1] != targetValues[2] && targetValues[0] != targetValues[2])
                {
                    GUILayout.Box(drWolfenstein3, GUILayout.ExpandHeight(false), GUILayout.ExpandWidth(true));
                }
                else
                {
                    GUILayout.Box(drWolfenstein2, GUILayout.ExpandHeight(false), GUILayout.ExpandWidth(true));
                }
            }
            else
            {
                GUILayout.Box(drWolfenstein1, GUILayout.ExpandHeight(false), GUILayout.ExpandWidth(true));
            }
        }
    }

    private void ShowAndEditTargetInGUI(int choiceOf3)
    {

        if (jaggedTargetIndexsArray[choiceOf3] == null)
        {
            jaggedTargetIndexsArray[choiceOf3] = new int[1];
        }

        //EditorGUILayout.BeginHorizontal();
        //jaggedTargetIndexsArray[choiceOf3][0] = EditorGUILayout.Popup(jaggedTargetIndexsArray[choiceOf3][0], targets);
        if (targets[jaggedTargetIndexsArray[choiceOf3][0]] != "multiple")
        {
            //targetValuesDictionaryArray[choiceOf3][0] = EditorGUILayout.TextField(targetValuesDictionaryArray[choiceOf3][0]);
            DisplayDictionaryArray(choiceOf3, 0);
        }
        else
        {
            EditorGUILayout.BeginHorizontal();
            if (int.TryParse(targetValuesDictionaryArray[choiceOf3][0], out int result))
            {
                targetValuesDictionaryArray[choiceOf3][0] = EditorGUILayout.IntSlider(result, 2, groupedTargetLimit).ToString();
                GUILayout.FlexibleSpace();
            }
            else
            {
                targetValuesDictionaryArray[choiceOf3][0] = "2";
            }
            EditorGUILayout.EndHorizontal();
        }
        //EditorGUILayout.EndHorizontal();
        if (targets[jaggedTargetIndexsArray[choiceOf3][0]] == "multiple")
        {
            if (int.TryParse(targetValues[choiceOf3], out int multiCountAmount))
            {
                if(jaggedTargetIndexsArray[choiceOf3] == null || jaggedTargetIndexsArray[choiceOf3].Length < multiCountAmount)
                {
                    //so with the extra zeroes at the end, I can just use the multiamountcount to determine how much the user chose
                    jaggedTargetIndexsArray[choiceOf3] = new int[groupedTargetLimit];
                    targetValuesDictionaryArray[choiceOf3] = new Dictionary<int, string>();
                }

                for (int i = 0; i < multiCountAmount; i++)
                {
                    DisplayDictionaryArray(choiceOf3, i);
                }
            

            }

        }
    }

    private void DisplayDictionaryArray(int choiceOf3, int i)
    {
        //do
        //{
        if (targetValuesDictionaryArray[choiceOf3].ContainsKey(i))
        {
            EditorGUILayout.BeginHorizontal();
            jaggedTargetIndexsArray[choiceOf3][i] = EditorGUILayout.Popup(jaggedTargetIndexsArray[choiceOf3][i], targets);
            targetValuesDictionaryArray[choiceOf3][i] = EditorGUILayout.TextField(targetValuesDictionaryArray[choiceOf3][i]);
            EditorGUILayout.EndHorizontal();
        }
        else
        {
            targetValuesDictionaryArray[choiceOf3].Add(i, "1");
        }
            //Debug.Log("Ihappende");

        //} while (!targetValuesDictionaryArray[choiceOf3].TryGetValue(i, out string _result));


    }
    //camelCase off stack overflow https://stackoverflow.com/questions/42310727/convert-string-to-camelcase-from-titlecase-c-sharp
    static string CamelCase(string s)
    {
        var x = s.Replace("_", "");
        if (x.Length == 0) return "null";
        x = System.Text.RegularExpressions.Regex.Replace(x, "([A-Z])([A-Z]+)($|[A-Z])",
            m => m.Groups[1].Value + m.Groups[2].Value.ToLower() + m.Groups[3].Value);
        return char.ToLower(x[0]) + x.Substring(1);
    }

    [MenuItem("Boom/Add To ipa", false, 49)]
    public static void CreateTargetsEditorWindow()
    {
        TargetsEditorWindow window = ScriptableObject.CreateInstance<TargetsEditorWindow>();
        window.ShowUtility();
    }
}

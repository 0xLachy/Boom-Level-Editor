using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;
using UnityEditor;

public class TargetsEditorWindow : EditorWindow
{
    //add goal, and mulitTargets
    public static string[] targets = { "coin", "ball", "bomb", "rocket", "time", "bowling pin", "boost tunnel", "spring board", "goal", "multiple" };
    public int[] targetIndexes = { 0, 0, 0 };
    public int[][] jaggedTargetsArray = new int[3][];
    public Dictionary<int, string>[] targetValuesDictionaryArray = new Dictionary<int, string>[3];
    public string[] targetValues = { "1", "1", "1" };
    [SerializeField] Texture2D coin;
    [SerializeField] Texture2D ball;
    [SerializeField] Texture2D bomb;
    [SerializeField] Texture2D rocket;
    [SerializeField] Texture2D bowlingPin;
    [SerializeField] Texture2D springboard;
    [SerializeField] Texture2D boostTunnel;
    [SerializeField] Texture2D goal;
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
        EditorGUILayout.LabelField("Edit the type of targets in script, type the value you want for each target into the corresponding box, " +
            "when finished click finished. type 0 if no touching, type all for touch/collect/explode all, any number for targets, eg 4", EditorStyles.wordWrappedLabel);
        GUILayout.Space(10);
        EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("Levels.plist"))
        {
            levelsPlistPath = EditorUtility.OpenFilePanelWithFilters("levels.plist should be found in boom.app", "", levelsPlistfilters);
        }
        levelsPlistPath = EditorGUILayout.TextField(levelsPlistPath);
        EditorGUILayout.EndHorizontal();

        GUILayout.Space(10);

        EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("New Level"))
        {
            levelPlhsPath = EditorUtility.OpenFilePanelWithFilters("levels.plist should be found in boom.app", "", levelsPlhsfilters);
        }
        levelPlhsPath = EditorGUILayout.TextField(levelPlhsPath);
        EditorGUILayout.EndHorizontal();

        GUILayout.Space(10);

        ShowAndEditTargetInGUI(0);

        GUILayout.Space(15);

        ShowAndEditTargetInGUI(1);

        GUILayout.Space(15);

        ShowAndEditTargetInGUI(2);

        if (!drWolfenstein1)
        {
            Debug.LogError("Missing texture, assign a texture in the inspector");
        }

        //targetValue1 != targetIndex2 || targetIndex2 != targetIndex3 || targetIndex1 != targetIndex3)
        if (targetIndexes[0] != targetIndexes[1] || targetIndexes[1] != targetIndexes[2] || targetIndexes[0] != targetIndexes[2])
        {
            if (targetIndexes[0] != targetIndexes[1] && targetIndexes[2] != targetIndexes[1] && targetIndexes[0] != targetIndexes[2])
            {
                GUILayout.Box(drWolfenstein3, GUILayout.ExpandHeight(false), GUILayout.ExpandWidth(true));
            }
            else if ((targetIndexes[0] == targetIndexes[1] && targetValues[0] != targetValues[1]) || (targetIndexes[1] == targetIndexes[2] && targetValues[1] != targetValues[2])
                || (targetIndexes[0] == targetIndexes[2] && targetValues[0] != targetValues[2]))
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

        if (GUILayout.Button("Add to plist"))
        {
            if (levelsPlistPath.Length != 0 && levelPlhsPath.Length != 0)
            {
                string customLevelName = Path.GetFileNameWithoutExtension(levelPlhsPath);
                //Makes it safer to add the level,
                if (customLevelName.Length < 7 || customLevelName.Substring(0, 7) != "Custom_")
                {
                    bool answer = EditorUtility.DisplayDialog("WARNING", $"the level \"{customLevelName}\" doesn't contain \"Custom_\" at the start of the name, " +
                        $"press ok if you are sure", "abort", "OK");
                    if (answer)
                    {
                        levelPlhsPath = "";
                        Close();
                    }
                    else
                    {
                        AddLevelToBoomIPA.AddToIpa(targets, targetIndexes, targetValues, levelsPlistPath, levelPlhsPath, customLevelName);
                    }
                }
                else
                {
                    AddLevelToBoomIPA.AddToIpa(targets, targetIndexes, targetValues, levelsPlistPath, levelPlhsPath, customLevelName);
                }

            }
            else
            {
                Debug.LogError("invalid path");
            }
            Close();
        }
        GUILayout.BeginHorizontal();
        for (int i = 0; i < targetIndexes.Length; i++)
        {
            int index = targetIndexes[i];
            switch (targets[index])
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
                case "multiple":
                    GUILayout.BeginVertical();
                    //GUILayout.BeginArea(new Rect(494.00f, 337.00f, 249.00f, 234.00f)); doesn't work
                    //(x: 494.00, y: 337.00, width: 249.00, height: 234.00) after for loop
                    for (int i1 = 0; i1 < targetValues[i].Length + 1; i1++)
                    {
                        int imageIndex = jaggedTargetsArray[i][i1];
                        switch (targets[imageIndex])
                        {
                            case "coin":
                                GUILayout.Box(coin, GUILayout.ExpandHeight(true), GUILayout.MinWidth(position.width / 3), GUILayout.MaxWidth(position.width / 3));
                                break;
                            case "ball":
                                //GUILayout.Box(ball, GUILayout.ExpandHeight(true), GUILayout.ExpandWidth(true));
                                GUILayout.Box(ball, GUILayout.MinWidth(position.width / 3), GUILayout.MaxWidth(position.width / 3));
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
                            default:
                                Debug.Log(targets[index] + " can't been found in the logo images");
                                break;
                        }
                    }
                    GUILayout.EndVertical();
                    break;
                default:
                    Debug.Log(targets[index] + " can't been found in the logo images");
                    break;
            }
        }
        //(x: 494.00, y: 337.00, width: 249.00, height: 234.00) after for loop
    }


    private void ShowAndEditTargetInGUI(int choiceOf3)
    {
            
        EditorGUILayout.BeginHorizontal();
        targetIndexes[choiceOf3] = EditorGUILayout.Popup(targetIndexes[choiceOf3], targets);
        if (targets[targetIndexes[choiceOf3]] != "multiple")
        {
            targetValues[choiceOf3] = EditorGUILayout.TextField(targetValues[choiceOf3]);
        }
        else
        {
            targetValues[choiceOf3] = EditorGUILayout.IntSlider(int.Parse(targetValues[choiceOf3]), 2, groupedTargetLimit).ToString();
            GUILayout.FlexibleSpace();
        }
        EditorGUILayout.EndHorizontal();
        if (targets[targetIndexes[choiceOf3]] == "multiple")
        {
            if (int.TryParse(targetValues[choiceOf3], out int multiCountAmount))
            {
                if(jaggedTargetsArray[choiceOf3] == null || jaggedTargetsArray[choiceOf3].Length < multiCountAmount)
                {
                    //so with the extra zeroes at the end, I can just use the multiamountcount to determine how much the user chose
                    jaggedTargetsArray[choiceOf3] = new int[groupedTargetLimit];
                    targetValuesDictionaryArray[choiceOf3] = new Dictionary<int, string>();
                }
                //else if (jaggedTargetsArray[choiceOf3].Length < multiCountAmount)
                //{
                //    int difference = multiCountAmount - jaggedTargetsArray[choiceOf3].Length;
                //    for (int i = difference; i < multiCountAmount; i++)
                //    {
                //        //needs to be a list because the array has set length, this is past the index or whatever
                //        jaggedTargetsArray[choiceOf3][i] = 1;
                //    }
                //}

                if (multiCountAmount == 1)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        StoreMultiTargetValues(choiceOf3, i);
                    }
                }
                else
                {
                    for (int i = 0; i < multiCountAmount; i++)
                    {
                        StoreMultiTargetValues(choiceOf3, i);
                    }
                }

            }

        }
    }

    private void StoreMultiTargetValues(int choiceOf3, int i)
    {
        //do
        //{
        if (targetValuesDictionaryArray[choiceOf3].ContainsKey(i))
        {
            EditorGUILayout.BeginHorizontal();
            jaggedTargetsArray[choiceOf3][i] = EditorGUILayout.Popup(jaggedTargetsArray[choiceOf3][i], targets);
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

    [MenuItem("Boom/Add To ipa", false, 49)]
    public static void CreateTargetsEditorWindow()
    {
        TargetsEditorWindow window = ScriptableObject.CreateInstance<TargetsEditorWindow>();
        window.ShowUtility();
    }
}

using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;
using UnityEditor;

public class TargetsEditorWindow : EditorWindow
{
    public static string[] targets = { "coin", "ball", "bomb", "rocket", "time", "bowling pin", "boost tunnel", "spring board" };
    public int[] targetIndexes = { 0, 0, 0 };
    public string[] targetValues = { "1", "1", "1" };
    [SerializeField] Texture2D coin;
    [SerializeField] Texture2D ball;
    [SerializeField] Texture2D bomb;
    [SerializeField] Texture2D rocket;
    [SerializeField] Texture2D bowlingPin;
    [SerializeField] Texture2D springboard;
    [SerializeField] Texture2D boostTunnel;
    [SerializeField] Texture2D timeImage;
    [SerializeField] Texture2D drWolfenstein1;
    [SerializeField] Texture2D drWolfenstein2;
    [SerializeField] Texture2D drWolfenstein3;

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

        EditorGUILayout.BeginHorizontal();
        targetIndexes[0] = EditorGUILayout.Popup(targetIndexes[0], targets);
        targetValues[0] = EditorGUILayout.TextField(targetValues[0]);
        EditorGUILayout.EndHorizontal();

        GUILayout.Space(10);

        EditorGUILayout.BeginHorizontal();
        targetIndexes[1] = EditorGUILayout.Popup(targetIndexes[1], targets);
        targetValues[1] = EditorGUILayout.TextField(targetValues[1]);
        EditorGUILayout.EndHorizontal();

        GUILayout.Space(10);

        EditorGUILayout.BeginHorizontal();
        targetIndexes[2] = EditorGUILayout.Popup(targetIndexes[2], targets);
        targetValues[2] = EditorGUILayout.TextField(targetValues[2]);
        EditorGUILayout.EndHorizontal();
      
        if (!drWolfenstein1)
        {
            Debug.LogError("Missing texture, assign a texture in the inspector");
        }
        
        //targetValue1 != targetIndex2 || targetIndex2 != targetIndex3 || targetIndex1 != targetIndex3)
        if (targetIndexes[0] != targetIndexes[1] || targetIndexes[1] != targetIndexes[2] || targetIndexes[0] != targetIndexes[2])
        {
            if(targetIndexes[0] != targetIndexes[1] && targetIndexes[2] != targetIndexes[1] && targetIndexes[0] != targetIndexes[2])
            {
                GUILayout.Box(drWolfenstein3, GUILayout.ExpandHeight(false), GUILayout.ExpandWidth(true));
            }
            else if((targetIndexes[0] == targetIndexes[1] && targetValues[0] != targetValues[1]) || (targetIndexes[1] == targetIndexes[2] && targetValues[1] != targetValues[2])
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
            if(targetValues[0] != targetValues[1] || targetValues[1] != targetValues[2] || targetValues[0] != targetValues[2])
            {
                if(targetValues[0] != targetValues[1] && targetValues[1] != targetValues[2] && targetValues[0] != targetValues[2])
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
            if(levelsPlistPath.Length != 0 && levelPlhsPath.Length != 0)
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
                        AddLevelToBoomIPA.ConvertTargetToDictionary(targets, targetValues);
                    }
                }
                else
                {
                    AddLevelToBoomIPA.ConvertTargetToDictionary(targets, targetValues);
                }

            }
            else
            {
                Debug.LogError("invalid path");
            }
            Close();
        }
        GUILayout.BeginHorizontal();
        foreach(int index in targetIndexes)
        {
            switch (targets[index])
            {
                case "coin":
                    GUILayout.Box(coin, GUILayout.ExpandHeight(true), GUILayout.ExpandWidth(true));
                    break;
                case "ball":
                    GUILayout.Box(ball, GUILayout.ExpandHeight(true), GUILayout.ExpandWidth(true));
                    break;
                case "bomb":
                    GUILayout.Box(bomb, GUILayout.ExpandHeight(true), GUILayout.ExpandWidth(true));
                    break;
                case "rocket":
                    GUILayout.Box(rocket, GUILayout.ExpandHeight(true), GUILayout.ExpandWidth(true));
                    break;
                case "time":
                    GUILayout.Box(timeImage, GUILayout.ExpandHeight(true), GUILayout.ExpandWidth(true));
                    break;
                case "bowling pin":
                    GUILayout.Box(bowlingPin, GUILayout.ExpandHeight(true), GUILayout.ExpandWidth(true));
                    break;
                case "boost tunnel":
                    GUILayout.Box(boostTunnel, GUILayout.ExpandHeight(true), GUILayout.ExpandWidth(true));
                    break;
                case "spring board":
                    GUILayout.Box(springboard, GUILayout.ExpandHeight(true), GUILayout.ExpandWidth(true));
                    break;
                default:
                    Debug.Log(targets[index] + " can't been found in the logo images");
                    break;
            }
        }
    }

    [MenuItem("Boom/Add To ipa", false, 50)]
    public static void CreateTargetsEditorWindow()
    {
        TargetsEditorWindow window = ScriptableObject.CreateInstance<TargetsEditorWindow>();
        window.ShowUtility();
    }
}

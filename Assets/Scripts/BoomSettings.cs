using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class BoomSettings : ScriptableObject
{
    public static bool shouldfocus = false;
    [SerializeField] public string defaultPlistPath = "";
    /*[Header("Default Target Stuff")]*/
    [SerializeField] private int[] defaultIndexes = new int[] { 0, 1, 8, 0, 4, 2, 3 };
    [SerializeField] private string[] defaultTargetValues = new string[] { "all", "1", "default", "0", "15", "2", "1" };
    [SerializeField] public int defaultBGIndex = 1;
    [Tooltip("How many targets to add")] [SerializeField] private int targetListCapacity = 3;

    /*[Header("Plist File Config")]*/
    [Tooltip("Add the new level at the index of the finder string level")] [SerializeField] private bool insertAtIndexFinderString = false;
    [Tooltip("Level name so that the script knows where the custom levels are")] [SerializeField] private string extremeLevelsIndexFinderString = "Lumberjack";

    /*[Header("Description Stuff")]*/
    [Tooltip("Makes the default description fit what it is being added to (you can still edit the description)")] [SerializeField] private bool autodescription = true;
    [Tooltip("descriptions are not just defined to groups of targets, you can add them to single targets")] [SerializeField] private bool singlesCanHaveDescription = false;
    [Tooltip("The text already in the description box when you click +")] [SerializeField] private string defaultDescription = "Add description here";

    public static string DefaultPlistPath { get; set; }
    public static int[] DefaultIndexes { get; private set; }
    public static string[] DefaultTargetValues { get; private set; }
    public static int DefaultBGIndex { get; set; }
    public static int TargetListCapacity { get; private set; }
    public static bool InsertAtIndexFinderString { get; private set; }
    public static string ExtremeLevelsIndexFinderString { get; private set; }
    public static bool Autodescription { get; private set; }
    public static bool SinglesCanHaveDescription { get; private set; }
    public static string DefaultDescription { get; private set; }

    private void OnEnable()
    {
        Refresh(this);
    }

    public static void Refresh(BoomSettings instance)
    {
        DefaultPlistPath = instance.defaultPlistPath;
        DefaultIndexes = instance.defaultIndexes;
        DefaultTargetValues = instance.defaultTargetValues;
        DefaultBGIndex = instance.defaultBGIndex;
        TargetListCapacity = instance.targetListCapacity;
        InsertAtIndexFinderString = instance.insertAtIndexFinderString;
        ExtremeLevelsIndexFinderString = instance.extremeLevelsIndexFinderString;
        Autodescription = instance.autodescription;
        SinglesCanHaveDescription = instance.singlesCanHaveDescription;
        DefaultDescription = instance.defaultDescription;
    }
}

public static class BoomSettingsRegister
{
   public const string SettingsPath = "Assets/Editor/BoomSettings.asset";
    [SettingsProvider]
    public static SettingsProvider CreateSettingsProvider()
    {
        if (BoomSettings.shouldfocus)
        {
            EditorUtility.FocusProjectWindow();
            BoomSettings.shouldfocus = false;
        }
        var targetsFoldout = true;
        var plistFoldout = true;
        var descriptionFoldout = false;

        return new SettingsProvider("Project/BoomSettings", SettingsScope.Project)
        {
            guiHandler = (searchContext) =>
            {
                var settings = Load();
                var serialized = new SerializedObject(settings);

                EditorGUI.BeginChangeCheck();

                EditorGUILayout.PropertyField(serialized.FindProperty("defaultIndexes"), new GUIContent("default indexes"));
                EditorGUILayout.PropertyField(serialized.FindProperty("defaultTargetValues"), new GUIContent("default values"));
                targetsFoldout = EditorGUILayout.BeginFoldoutHeaderGroup(targetsFoldout, "Target");

                if (targetsFoldout)
                {
                    EditorGUILayout.PropertyField(serialized.FindProperty("defaultBGIndex"), new GUIContent("default background index"));
                    EditorGUILayout.PropertyField(serialized.FindProperty("targetListCapacity"), new GUIContent("amount of targets"));
                }
                EditorGUILayout.EndFoldoutHeaderGroup();

                plistFoldout = EditorGUILayout.BeginFoldoutHeaderGroup(plistFoldout, "Plist");

                if (plistFoldout)
                {
                    EditorGUILayout.PropertyField(serialized.FindProperty("insertAtIndexFinderString"), new GUIContent("insert new level before finder string"));
                    EditorGUILayout.PropertyField(serialized.FindProperty("extremeLevelsIndexFinderString"), new GUIContent("finder string"));
                    EditorGUILayout.PropertyField(serialized.FindProperty("defaultPlistPath"), new GUIContent("default plist path"));
                }
                EditorGUILayout.EndFoldoutHeaderGroup();

                descriptionFoldout = EditorGUILayout.BeginFoldoutHeaderGroup(descriptionFoldout, "Description");

                if (descriptionFoldout)
                {
                    EditorGUILayout.PropertyField(serialized.FindProperty("autodescription"), new GUIContent("auto description"));
                    EditorGUILayout.PropertyField(serialized.FindProperty("singlesCanHaveDescription"), new GUIContent("singles can have description"));
                    EditorGUILayout.PropertyField(serialized.FindProperty("defaultDescription"), new GUIContent("default description"));
                }
                EditorGUILayout.EndFoldoutHeaderGroup();

                EditorGUILayout.HelpBox("To reset settings, delete the asset file (in editor folder) and go to BOOM -> Add to Ipa", MessageType.Info);

                if (EditorGUI.EndChangeCheck())
                {
                    serialized.ApplyModifiedProperties();
                    BoomSettings.Refresh(settings);
                }
            },

            keywords = new HashSet<string>(new[] { "Boom Settings", "default target" })
        };
    }

    //[MenuItem("Boom/Regenerate Settings", false, 55)]
    public static BoomSettings Load()
    {
        var settings = AssetDatabase.LoadAssetAtPath<BoomSettings>(SettingsPath);
        
        if (settings == null)
        {
            settings = ScriptableObject.CreateInstance<BoomSettings>();
            AssetDatabase.CreateAsset(settings, SettingsPath);
            AssetDatabase.SaveAssets();
        }

        return settings;
    }
}

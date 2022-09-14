using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Claunia.PropertyList;
using System;
using System.IO;
using UnityEditor;
using System.Text.RegularExpressions;


public class AddLevelToBoomIPA : MonoBehaviour
{
    static NSArray targetsNSArray;
    static NSDictionary[] arrayOfNSDictionaryTargets;
    static NSObject allBoomLevelsPlist;
    static string extremeLevelsIndexFinderString = BoomSettings.ExtremeLevelsIndexFinderString;
    static bool insertAtIndexFinderString = BoomSettings.InsertAtIndexFinderString;
    static int newLevelInsertionIndex;
    //[MenuItem("Boom/Add To ipa", false, 50)]
    public static void AddToIpa(string[] targets, List<List<int>> targetIndexesListList, List<List<string>> targetValuesListList,
        Dictionary<int, string> targetDescriptions, string levelsPlistPath, string levelPlhsPath, string customLevelName, string inGameName, string bgName)
    {
        
        var fileContent = File.ReadAllBytes(levelsPlistPath);
        allBoomLevelsPlist = PropertyListParser.Parse(fileContent);
        if (allBoomLevelsPlist is NSDictionary dict)
        {
            ConvertTargetToDictionary(targets, targetIndexesListList, targetValuesListList, targetDescriptions);
            FindCustomLevelsIndexInPlist((NSArray)dict["LevelGroups"], customLevelName, inGameName, bgName, levelsPlistPath);
            AddLevelFileToIPA(levelsPlistPath, levelPlhsPath);
            Debug.Log("Level added to ipa, and to levels.plist");
        }
        else
        {
            EditorUtility.DisplayDialog("Level not valid",
                "The level file could not be read because the structure is invalid.", "OK");
        }
    }

    private static void AddLevelFileToIPA(string levelsPlistPath, string levelPlhsPath)
    {
        string levelsDir = Path.GetDirectoryName(levelsPlistPath);       
        string plhsInBoomPath = levelsDir + Path.DirectorySeparatorChar + Path.GetFileName(levelPlhsPath);
        if (File.Exists(plhsInBoomPath))
        {
            // if they say no don't continue
            if(!EditorUtility.DisplayDialog("Level File Exists", $"the level \"{levelPlhsPath}\" \"{plhsInBoomPath}\" already exists, do you want to replace it?", "yes", "no"))
            {
                return;
            }
        }
        // copy the level from the editor, and put that into the ipa itself
        File.Copy(levelPlhsPath, plhsInBoomPath, true);
    }

    //The index should always be 7 generally, but with different ipa's and stuff, it's safer this way
    static void FindCustomLevelsIndexInPlist(NSArray levelGroupsArray, string customLevelName, string inGameName, string bgName, string levelsPlistPath)
    {
        int CustomLevelsDictIndex = 0;
        for (int index = 0; index < levelGroupsArray.Count; index++)
        {
            NSObject levelsGroup = levelGroupsArray[index];
            NSDictionary levelsGroupDict = (NSDictionary)levelsGroup;
            if (levelsGroupDict.ContainsKey("Levels"))
            {
                NSArray levelsArray = (NSArray)levelsGroupDict["Levels"];
                for (int i = 0; i < levelsArray.Count; i++)
                {
                    NSObject level = levelsArray[i];
                    NSDictionary levelDict = (NSDictionary)level;
                    if (levelDict.ContainsKey("LevelName"))
                    {
                        if ((string)(NSString)levelDict["LevelName"] == extremeLevelsIndexFinderString)
                        {
                            //This is the first extreme level, which means that this is a a part of the extreme levels dict
                            CustomLevelsDictIndex = index;
                            newLevelInsertionIndex = i;
                        }
                    }
                }
            }
        }
        AddLevelToPlist(CustomLevelsDictIndex, levelGroupsArray, customLevelName, inGameName, bgName, levelsPlistPath);
    }

    private static void AddLevelToPlist(int customLevelsDictIndex, NSArray levelGroupsArray, string LevelNameFromFile, string inGameName, string bgName, string levelsPlistPath)
    {
        bool isNewLevelInPlist = true;
        NSDictionary newLevelDict = new NSDictionary();
        newLevelDict.Add("RequiredSuperStars", 0);
        newLevelDict.Add("Targets", targetsNSArray);
        newLevelDict.Add("bgName", bgName);
        newLevelDict.Add("LevelName", inGameName);
        newLevelDict.Add("Version", "1");
        newLevelDict.Add("LevelId", LevelNameFromFile);

        if (customLevelsDictIndex == 0) { Debug.LogError("Don't know where to put the level/s"); return; }
        NSDictionary customLevelsDict = (NSDictionary)levelGroupsArray[customLevelsDictIndex];
        NSArray levelsArray = (NSArray)customLevelsDict["Levels"];
        foreach (NSObject level in levelsArray)
        {
            NSDictionary levelDict = (NSDictionary)level;
            if (levelDict.ContainsKey("LevelId") || levelDict.ContainsKey("LevelName"))
            {
                if (((string)(NSString)levelDict["LevelId"] == LevelNameFromFile) || ((string)(NSString)levelDict["LevelName"] == inGameName))
                {
                    isNewLevelInPlist = false;
                    //returns true for no, and false for yes, they are flipped so that the default option is no
                    bool replaceTargets = EditorUtility.DisplayDialog("Level Conflict", $"the level \"{LevelNameFromFile}.plhs\" \"{inGameName}\" " +
    "already exists, do you want to replace the targets, background and update the level name?", "yes", "no");
                    if (replaceTargets)
                    {
                        levelDict["Targets"] = targetsNSArray;
                        levelDict["bgName"] = newLevelDict["bgName"];
                        levelDict["LevelName"] = newLevelDict["LevelName"];
                    }
                }
            }

        }
        if (isNewLevelInPlist)
        {
            //use insert to have it placed under where you put your last level
            if (insertAtIndexFinderString)
            { 
                levelsArray.Insert(newLevelInsertionIndex, newLevelDict);
            }
            else
            {
                levelsArray.Add(newLevelDict);
            }
        }
        Directory.CreateDirectory("./Levels");
        PropertyListParser.SaveAsXml(allBoomLevelsPlist, new FileInfo(levelsPlistPath));
    }

    public static void ConvertTargetToDictionary(string[] targets, List<List<int>> targetIndexesListList, List<List<string>> targetValuesListList, Dictionary<int, string> targetDescriptions)
    {
        arrayOfNSDictionaryTargets = new NSDictionary[targetIndexesListList.Count];
        bool all = false;
        bool none = false;
        bool noNum = false;
        bool finWith = false;
        bool rightbutton = false;
        double targetNumber = 0;
        bool notANumber = false;
        bool isCustom = false;
        for (int i1 = 0; i1 < targetIndexesListList.Count; i1++)
        {
            arrayOfNSDictionaryTargets[i1] = new NSDictionary();
            List<int> listInt = targetIndexesListList[i1];
            var editingTarget = arrayOfNSDictionaryTargets[i1];
            if (listInt.Count > 1)
            {
                editingTarget.Add("Group", new NSArray(listInt.Count));
                NSArray group = (NSArray)editingTarget["Group"];
                for (int i2 = 0; i2 < listInt.Count; i2++)
                {
                    all = false;
                    none = false;
                    noNum = false;
                    finWith = false;
                    rightbutton = false;
                    targetNumber = 0;
                    notANumber = false;
                    isCustom = false;

                    int targetIndex = listInt[i2];
                    if (listInt.Count > 1)
                    {
                        group.Add(new NSDictionary());
                        if (targets[targetIndex] == "custom")
                        {
                            isCustom = true;
                        }
                        else
                        {
                            GetCorrectValueFromString(targetValuesListList[i1][i2], ref all, ref none, ref targetNumber, ref notANumber, ref finWith, ref rightbutton, ref noNum);
                        }
                        group[i2] = AddTargetToNSDictionary(targets, all, none, targetNumber, notANumber, targetIndex, finWith, rightbutton, noNum, isCustom, targetValuesListList[i1][i2],
                            (NSDictionary)group[i2]);

                    }
                }
                editingTarget["Group"] = group;
                arrayOfNSDictionaryTargets[i1] = editingTarget;
            }
            else
            {
                all = false;
                none = false;
                noNum = false;
                finWith = false;
                rightbutton = false;
                targetNumber = 0;
                notANumber = false;
                isCustom = false;

                if (targets[listInt[0]] == "custom")
                {
                    isCustom = true;
                }
                else
                {
                    GetCorrectValueFromString(targetValuesListList[i1][0], ref all, ref none, ref targetNumber, ref notANumber, ref finWith, ref rightbutton, ref noNum);
                }
                arrayOfNSDictionaryTargets[i1] = AddTargetToNSDictionary(targets, all, none, targetNumber, notANumber, listInt[0], finWith, rightbutton, noNum, isCustom,
                    targetValuesListList[i1][0], editingTarget);
            }

            if (targetDescriptions.ContainsKey(i1))
            {
                arrayOfNSDictionaryTargets[i1].Add("Description", targetDescriptions[i1]);
            }
        }
        targetsNSArray = new NSArray(arrayOfNSDictionaryTargets.Length);
        for (int i = 0; i < arrayOfNSDictionaryTargets.Length; i++)
        {
            //Debug.Log(arrayOfNSDictionaryTargets[i]["Type"]);
            targetsNSArray.Add(arrayOfNSDictionaryTargets[i]);
        }
    }

    private static NSDictionary AddTargetToNSDictionary(string[] targets, bool all, bool none, double targetNumber, bool isNumber, int targetIndex, bool finWith, 
        bool rightbutton, bool noNum, bool isCustom, string customValue, NSDictionary Editingdict)
    {
        bool tryNoneAgain = false;
        if (isNumber || none)
        {
            
            if(none)
            {
                targetNumber = 0;
                Editingdict.Add("Target", (int)targetNumber);

                switch (targets[targetIndex])
                {
                    case "ball":
                        Editingdict.Add("Type", "Touch ball");
                        break;
                    case "bomb":
                        Editingdict.Add("Type", "Bombs");
                        break;
                    case "rocket":
                        Editingdict.Add("Type", "Rockets");
                        break;
                    case "bowling pin":
                        Editingdict.Add("Type", "Touch bowling pin");
                        break;
                    case "spring board":
                        Editingdict.Add("Type", "Springboards");
                        break;
                    case "break ball":
                        Editingdict.Add("Type", "Break ball");
                        break;
                    default:
                        tryNoneAgain = true;
                        break;
                }
            }
            else
            {
                Editingdict.Add("Target", (int)targetNumber);
                switch (targets[targetIndex])
                {
                    case "coin":
                        Editingdict.Add("Type", "Pickups");
                        break;
                    case "ball":
                        Editingdict.Add("Type", "Touch ball");
                        break;
                    case "bomb":
                        Editingdict.Add("Type", "Bombs");
                        break;
                    case "rocket":
                        Editingdict.Add("Type", "Rockets");
                        break;
                    case "bowling pin":
                        Editingdict.Add("Type", "Touch bowling pin");
                        break;
                    case "boost tunnel":
                        Editingdict.Add("Type", "Boost tunnel");
                        break;
                    case "spring board":
                        Editingdict.Add("Type", "Springboards");
                        break;
                    case "goal"://probably breaks
                        Editingdict.Add("Type", "Goal");
                        break;
                    case "break ball":
                        Editingdict.Add("Type", "Break ball");
                        break;
                    case "time":
                        Editingdict.Remove("Target");
                        Editingdict.Add("Target", double.Parse(String.Format("{0:00.000}", targetNumber)));
                        Editingdict.Add("Type", "Time");
                        break;
                    default:
                        tryNoneAgain = true;
                        Debug.Log(targets[targetIndex] + " number Doesn't go into any");
                        break;
                }
            }
        }
        else if (!isNumber || tryNoneAgain)
        {
            switch (targets[targetIndex])
            {
                //finWith rightbutton noNum
                case "coin":
                    if (all)
                        Editingdict.Add("Type", "All pickups");
                    else if (none || (targetNumber == 0 && !isNumber))
                        Editingdict.Add("Type", "No coins");
                    else if (noNum)//might break
                        Editingdict.Add("Type", "pickups");
                    break;
                case "ball":
                    if (all)//not sure if this works, but it's funny, try Touch all balls
                        Editingdict.Add("Type", "Touch balls");
                    break;
                case "bomb":
                    if (all || noNum)
                        Editingdict.Add("Type", "All bombs");
                    break;
                case "rocket":
                    if (all || noNum)
                        Editingdict.Add("Type", "Rockets");
                    else if (finWith)
                        Editingdict.Add("Type", "Finish with rocket");
                    break;
                case "time":
                    Editingdict.Add("Target", double.Parse(String.Format("{0:0.000000}", targetNumber)));
                    Editingdict.Add("Type", "Time");
                    break;
                case "bowling pin":
                    if (all || noNum)
                        Editingdict.Add("Type", "Touch bowling pin");
                    break;
                case "boost tunnel":
                    if (all)
                        Editingdict.Add("Type", "all boost tunnels");
                    else if (noNum)
                        Editingdict.Add("Type", "Boost tunnel");
                    else if (none || (targetNumber == 0 && !isNumber))
                        Editingdict.Add("Type", "No boost tunnels");
                    break;
                case "spring board":
                    if (all || noNum)//might cause error
                        Editingdict.Add("Type", "Springboards");
                    break;
                case "goal":
                    Editingdict.Add("Type", "Goal");
                    break;
                case "button":
                    if (rightbutton)
                        Editingdict.Add("Type", "Complete Right Button");
                    else//not sure if this works
                        Editingdict.Add("Type", "Complete Left Button");
                    break;
                default:
                    Debug.Log(targets[targetIndex] + "Doesn't go into any (ignore if it says custom or your custom text)");
                    break;
            }
        }
        if(isCustom)
        {
            //TODO: try split the value by comma's and if true, then the number will be the target, and type will be the words
            Editingdict.Add("Type", customValue);
        }
        return Editingdict;  
    }

    private static void GetCorrectValueFromString(string targetValue, ref bool all, ref bool none, ref double targetNumber, ref bool isNumber, ref bool finWith, ref bool rightbutton, ref bool noNum)
    {
        string valueToConvert = targetValue.ToLower();
        Regex.Replace(valueToConvert, @"\s+", "");
        //if (Regex.IsMatch(valueToConvert, @"\d"))
        //{
        //    Debug.LogError("string can only contain numbers or letters");
        //}
        if (valueToConvert == "all" || valueToConvert == "cac" || valueToConvert == "eab" )
        {
            all = true;
        }
        else if (valueToConvert == "finwith" || valueToConvert == "finish with" || valueToConvert == "fin" || valueToConvert == "finishwith")
        {
            finWith = true;
        }
        else if (valueToConvert == "rightbutton" || valueToConvert == "right button" || valueToConvert == "rb" || valueToConvert == "right" || valueToConvert == "cwlb")
        {
            rightbutton = true;
        }
        else if (valueToConvert == "leftbutton" || valueToConvert == "left button" || valueToConvert == "lb" || valueToConvert == "left" || valueToConvert == "cwrb")
        {
            rightbutton = false;
        }
        else if (valueToConvert == "nonum" || valueToConvert == "no target" || valueToConvert == "no number" || valueToConvert == "default" || valueToConvert == "common" || valueToConvert == "tab")
        {
            noNum = true; 
        }
        else if (valueToConvert == "none")
        {
            none = true;
        }
        else
        {
            isNumber = Double.TryParse(valueToConvert, out targetNumber);
        }
    }

}

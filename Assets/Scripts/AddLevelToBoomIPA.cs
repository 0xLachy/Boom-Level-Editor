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
    static StreamWriter sw;
    static NSArray targetsNSArray;
    static NSDictionary[] arrayOfNSDictionaryTargets;
    //[MenuItem("Boom/Add To ipa", false, 50)]
    public static void AddToIpa(string[] targets, int[][] jaggedTargetsArray, Dictionary<int, string>[] targetValuesDictionaryArray, string levelsPlistPath, string levelPlhsPath, string customLevelName)
    {


        var fileContent = File.ReadAllBytes(levelsPlistPath);
        NSObject obj = PropertyListParser.Parse(fileContent);
        if (obj is NSDictionary dict)
        {
            ConvertTargetToDictionary(targets, jaggedTargetsArray, targetValuesDictionaryArray);
            FindCustomLevelsIndexInPlist((NSArray)dict["LevelGroups"], customLevelName);
            Debug.Log("Made it past the if statement");
        }
        else
        {
            EditorUtility.DisplayDialog("Level not valid",
                "The level file could not be read because the structure is invalid.", "OK");
        }
    }

    //The index should always be 7 generally, but with different ipa's and stuff, it's safer this way
    static void FindCustomLevelsIndexInPlist(NSArray levelGroupsArray, string customLevelName)
    {
        int CustomLevelsDictIndex = 0;
        for (int index = 0; index < levelGroupsArray.Count; index++)
        {
            NSObject levelsGroup = levelGroupsArray[index];
            NSDictionary levelsGroupDict = (NSDictionary)levelsGroup;
            if (levelsGroupDict.ContainsKey("Levels"))
            {
                NSArray levelsArray = (NSArray)levelsGroupDict["Levels"];
                foreach (NSObject level in levelsArray)
                {
                    NSDictionary levelDict = (NSDictionary)level;
                    if (levelDict.ContainsKey("LevelName"))
                    {
                        if ((string)(NSString)levelDict["LevelName"] == "House of Balance")
                        {
                            //This is the first extreme level, which means that this is a a part of the extreme levels dict
                            CustomLevelsDictIndex = index;
                        }
                    }
                }
            }
        }
        AddLevelToPlist(CustomLevelsDictIndex, levelGroupsArray, customLevelName, "fix later");
    }

    private static void AddLevelToPlist(int customLevelsDictIndex, NSArray levelGroupsArray, string LevelNameFromFile, string newLevelName)
    {
        bool isNewLevelInPlist = true;
        if (customLevelsDictIndex == 0) { Debug.Log("Don't know where to put the level/s"); return; }
        NSDictionary customLevelsDict = (NSDictionary)levelGroupsArray[customLevelsDictIndex];
        NSArray levelsArray = (NSArray)customLevelsDict["Levels"];
        foreach (NSObject level in levelsArray)
        {
            NSDictionary levelDict = (NSDictionary)level;
            if (levelDict.ContainsKey("LevelId"))
            {
                if ((string)(NSString)levelDict["LevelId"] == LevelNameFromFile)
                {
                    isNewLevelInPlist = false;
                    //creating a function in here to edit the targets
                    EditTargets(LevelNameFromFile, levelDict);
                    Debug.Log("The level already exists in the levels.plist");
                }
            }
        }
        if (isNewLevelInPlist)
        {

            //        				<dict>
            //	<key>RequiredSuperStars</key>
            //	<integer>0</integer>
            //	<key>Targets</key>
            //	<array>
            //		<dict>
            //			<key>Target</key>
            //			<integer>1</integer>
            //			<key>Type</key>
            //			<string>Touch ball</string>
            //		</dict>
            //		<dict>
            //			<key>Type</key>
            //			<string>All pickups</string>
            //		</dict>
            //		<dict>
            //			<key>Target</key>
            //			<string>1</string>
            //			<key>Type</key>
            //			<string>Bombs</string>
            //		</dict>
            //	</array>
            //	<key>bgName</key>
            //	<string>JungleBG.plist</string>
            //	<key>LevelName</key>
            //	<string>Twin Towers</string>
            //	<key>Version</key>
            //	<string>1</string>
            //	<key>LevelId</key>
            //	<string>Custom_TwinTowers</string>
            //</dict>
            NSDictionary newLevelDict = new NSDictionary();
            newLevelDict.Add("RequiredSuperStars", 0);
            newLevelDict.Add("Targets", targetsNSArray);
            //TODO get BGName
        }
    }

    private static void EditTargets(string customLevelName, NSDictionary levelDict)
    {
        throw new NotImplementedException();
    }

    //using 2 arrays instead of a dictionary, need to fix that later

    public static void ConvertTargetToDictionary(string[] targets, int[][] jaggedTargetIndexArray, Dictionary<int, string>[] targetValuesDictionaryArray)
    {
        arrayOfNSDictionaryTargets = new NSDictionary[jaggedTargetIndexArray.Length];
        bool all = false;
        bool none = false;
        bool noNum = false;
        bool finWith = false;
        bool rightbutton = false;
        double targetNumber = 0;
        bool notANumber = false;
        bool isCustom = false;
        foreach (int[] choiceOf3Index in jaggedTargetIndexArray)
        {
            foreach(int targetIndex in choiceOf3Index)
            {
                arrayOfNSDictionaryTargets[targetIndex] = new NSDictionary();
                //Debug.Log(arrayOfNSDictionaryTargets[targetIndex] + " just made to new NSDict");
                var editingTarget = arrayOfNSDictionaryTargets[targetIndex];
                if (targets[targetIndex] == "multiple")
                {
                    int amountInGroup = int.Parse(targetValuesDictionaryArray[targetIndex][0]);
                    editingTarget.Add("Group", new NSArray(amountInGroup));
                    NSArray group = (NSArray)editingTarget["group"];
                    for (int i = 0; i < amountInGroup; i++)
                    {
                        group[i] = new NSDictionary();
                        int jaggedIndex = jaggedTargetIndexArray[targetIndex][i];
                        if (targets[jaggedIndex] == "custom")
                        {
                            isCustom = true;
                        }
                        else
                        {
                            GetCorrectValueFromString(targetValuesDictionaryArray[targetIndex][jaggedIndex], ref all, ref none, ref targetNumber, ref notANumber, ref finWith, ref rightbutton, ref noNum);
                        }
                        group[i] = AddTargetToNSDictionary(targets, all, none, targetNumber, notANumber, i, finWith, rightbutton, noNum, isCustom, targetValuesDictionaryArray[targetIndex][jaggedIndex],
                            (NSDictionary)group[i]);
                    }
                }
                else
                {
                    GetCorrectValueFromString(targetValuesDictionaryArray[targetIndex][0], ref all, ref none, ref targetNumber, ref notANumber, ref finWith, ref rightbutton, ref noNum);
                }
                if (targets[targetIndex] == "custom") { isCustom = true; }
                arrayOfNSDictionaryTargets[targetIndex] = AddTargetToNSDictionary(targets, all, none, targetNumber, notANumber, targetIndex, finWith, rightbutton, noNum, isCustom,
                    targetValuesDictionaryArray[targetIndex][0], editingTarget);
            }
        
        }
        targetsNSArray = new NSArray(arrayOfNSDictionaryTargets.Length);
        for (int i = 0; i < arrayOfNSDictionaryTargets.Length; i++)
        {
            targetsNSArray.Add(arrayOfNSDictionaryTargets[i]);
        }
    }

    private static NSDictionary AddTargetToNSDictionary(string[] targets, bool all, bool none, double targetNumber, bool notANumber, int targetIndex, bool finWith, 
        bool rightbutton, bool noNum, bool isCustom, string customValue, NSDictionary Editingdict)
    {
        bool tryNoneAgain = false;
        if (!notANumber || none)
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
                    default:
                        Debug.Log("number Doesn't go into any");
                        break;
                }
            }
        }
        else if (notANumber || tryNoneAgain)
        {
            switch (targets[targetIndex])
            {
                //finWith rightbutton noNum
                case "coin":
                    if (all)
                        Editingdict.Add("Type", "All pickups");
                    else if (none || (targetNumber == 0 && !notANumber))
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
                    else if (none || (targetNumber == 0 && !notANumber))
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
                    Debug.Log("Doesn't go into any");
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

    private static void GetCorrectValueFromString(string targetValue, ref bool all, ref bool none, ref double targetNumber, ref bool notANumber, ref bool finWith, ref bool rightbutton, ref bool noNum)
    {
        string valueToConvert = targetValue.ToLower();
        Regex.Replace(valueToConvert, @"\s+", "");
        //if (Regex.IsMatch(valueToConvert, @"\d"))
        //{
        //    Debug.LogError("string can only contain numbers or letters");
        //}
        if (valueToConvert == "all")
        {
            all = true;
        }
        else if (valueToConvert == "finwith" || valueToConvert == "finish with" || valueToConvert == "fin" || valueToConvert == "finishwith")
        {
            finWith = true;
        }
        else if (valueToConvert == "rightbutton" || valueToConvert == "right button" || valueToConvert == "rb" || valueToConvert == "right")
        {
            rightbutton = true;
        }
        else if (valueToConvert == "leftbutton" || valueToConvert == "left button" || valueToConvert == "lb" || valueToConvert == "left")
        {
            rightbutton = false;
        }
        else if (valueToConvert == "nonum" || valueToConvert == "no target" || valueToConvert == "no number" || valueToConvert == "default" || valueToConvert == "common")
        {
            noNum = true;
        }
        else if (valueToConvert == "none")
        {
            none = true;
        }
        else
        {
            notANumber = Double.TryParse(valueToConvert, out targetNumber);
        }
    }

}

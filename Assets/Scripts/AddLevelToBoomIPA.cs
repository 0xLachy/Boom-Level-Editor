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
    static NSDictionary dictionaryTarget1 = new NSDictionary();
    static NSDictionary dictionaryTarget2 = new NSDictionary();
    static NSDictionary dictionaryTarget3 = new NSDictionary();
    static NSDictionary[] dictionaryTargetArray = { dictionaryTarget1, dictionaryTarget2, dictionaryTarget3 };
    //[MenuItem("Boom/Add To ipa", false, 50)]
    public static void AddToIpa(string[] targets, int[] targetIndexes, string[] targetValues, string levelsPlistPath, string levelPlhsPath, string customLevelName)
    {


        var fileContent = File.ReadAllBytes(levelsPlistPath);
        NSObject obj = PropertyListParser.Parse(fileContent);
        if (obj is NSDictionary dict)
        {
            ConvertTargetToDictionary(targets, targetIndexes, targetValues);
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
            if(levelsGroupDict.ContainsKey("Levels"))
            {
                NSArray levelsArray = (NSArray)levelsGroupDict["Levels"];
                foreach(NSObject level in levelsArray)
                {
                    NSDictionary levelDict = (NSDictionary)level;
                    if(levelDict.ContainsKey("LevelName"))
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
        AddLevelToPlist(CustomLevelsDictIndex, levelGroupsArray, customLevelName);
    }

    private static void AddLevelToPlist(int customLevelsDictIndex, NSArray levelGroupsArray, string customLevelName)
    {
        bool isNewLevelInPlist = true;
        if(customLevelsDictIndex == 0) { Debug.Log("Don't know where to put the level/s"); return; }
        NSDictionary customLevelsDict = (NSDictionary)levelGroupsArray[customLevelsDictIndex];
        NSArray levelsArray = (NSArray)customLevelsDict["Levels"];
        foreach(NSObject level in levelsArray)
        {
            NSDictionary levelDict = (NSDictionary)level;
            if (levelDict.ContainsKey("LevelId"))
            {
                if ((string)(NSString)levelDict["LevelId"] == customLevelName)
                {
                    isNewLevelInPlist = false;
                    //creating a function in here to edit the targets
                    EditTargets(customLevelName, levelDict);
                    Debug.Log("The level already exists in the levels.plist");
                }
            }
        }
        if(isNewLevelInPlist)
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
            //newLevelDict.Add("Targets", new NSArray(3)
            //{

            //})
            //levelsArray.Add(nsobject)
        }
    }

    private static void EditTargets(string customLevelName, NSDictionary levelDict)
    {
        throw new NotImplementedException();
    }

    //using 2 arrays instead of a dictionary, need to fix that later
    
    public static void ConvertTargetToDictionary(string[] targets, int[] targetIndexes, string[] targetValues)
    {
        bool all = false;
        bool none = false;
        double targetNumber = 0;
        bool notANumber = false;
        foreach(int targetIndex in targetIndexes)
        {
            string stringToConvert = targetValues[targetIndex].ToLower();
            Regex.Replace(stringToConvert, @"\s+", "");
            if (Regex.IsMatch(stringToConvert, @"\d"))
            {
                Debug.LogError("string can only contain numbers or letters");
            }
            else if(stringToConvert == "all")
            {
                all = true;
            }
            else if(stringToConvert == "none")
            {
                none = true;
            }
            else
            {
                notANumber = Double.TryParse(stringToConvert, out targetNumber);
            }
            //foreach (KeyValuePair<int, string> targetDict in targetValuesDictionaryArray[i])
            //String.Format("{0:0.000000}", DefaultValuesReferences.GORS[spriteName][retrievingIndex])
            var editingTarget = dictionaryTargetArray[targetIndex];
            //NSDictionaryTargets[targetIndex] = new NSDictionary();
            switch (targets[targetIndex])
            {
                case "coin":
                    if (all)
                    {
                        editingTarget.Add("Type", "All pickups");
                    }
                    else if (none || (targetNumber == 0 && !notANumber))
                    {
                        editingTarget.Add("Type", "No coins");
                    }
                    else if (!notANumber)
                    {
                        editingTarget.Add("Type", "soemthing");
                    }
                    break;
                default:
                    Debug.Log("Doesn't go into any");
                    break;
            }
        }
        NSArray targetNSArry = new NSArray(3) { dictionaryTarget1, dictionaryTarget2, dictionaryTarget3 };
    }
}

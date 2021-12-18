using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Claunia.PropertyList;
using System.Linq;
using UnityEditor;



public class AutoCoderFixtureFixer : MonoBehaviour
{
    static StreamWriter sw;
    static string fileWriteLocation = "Levels/AutoCode.txt";
    static bool firstNumber = true;
    static bool pshsFile;
    [MenuItem("Boom/AutoCode", false, 50)]
    static void AutoCode()
    {
        Debug.Log($"Writing Code to {fileWriteLocation}");
        string[] filters = { "boom extensions", "plhs,pshs", "All Files", "*" };
        string path = EditorUtility.OpenFilePanelWithFilters("Open boom file with ShapeFixtures", "", filters);
        pshsFile = EditorUtility.DisplayDialog("PSHS File or PLHS File",
                "chose\"PSHS\" for batch fixture grabbing, Chose \"PLHS\" for getting the fixtures from a level", "PSHS", "PLHS");
        
        if (path.Length != 0)
        {
            var fileContent = File.ReadAllBytes(path);
            NSObject obj = PropertyListParser.Parse(fileContent);
            if (obj is NSDictionary dict)
            {
                WriteTheArraysPLHS((NSArray)dict["SPRITES_INFO"]);
            }
            else
            {
                EditorUtility.DisplayDialog("Level not valid",
                    "The level file could not be read because the structure is invalid.", "OK");
            }
        }
    }
    private static void WriteTheArraysPLHS(NSArray sprites)
    {
        //could probably save to somewhere else, but it's sort of a temp file
        Directory.CreateDirectory("./Levels");
        sw = File.CreateText(fileWriteLocation);
        try
        {
            foreach (NSObject obj in sprites)
            {
                NSDictionary dict = (NSDictionary)obj;
                string name;
                if (dict.ContainsKey("PhysicProperties"))
                {
                    if (pshsFile)
                    {
                        NSDictionary textureProperties = (NSDictionary)dict["TextureProperties"];
                        name = textureProperties["Name"].ToString();
                    }
                    else
                    {
                        NSDictionary generalProperties = (NSDictionary)dict["GeneralProperties"];
                        name = generalProperties["UniqueName"].ToString();
                    }

                    NSDictionary physicProperties = (NSDictionary)dict["PhysicProperties"];
                    if (pshsFile) { AnalyzeShapeFixtures(name, physicProperties, "Fixtures"); }
                    else { AnalyzeShapeFixtures(name, physicProperties, "ShapeFixtures"); }                  
                }
            }
        }
        finally
        {
            sw?.Dispose();
        }

    }

    private static void AnalyzeShapeFixtures(string name, NSDictionary physicProperties, string fixturesWord)
    {
        if (physicProperties.ContainsKey(fixturesWord))
        {
            NSArray shapeFixtures = (NSArray)physicProperties[fixturesWord];
            //If shapefixtures is empty, don't write to the file and exit out early
            if (shapeFixtures.Count == 0) { return; }
            sw.WriteLine($"\tpublic static void {name}(NSDictionary physProps)");
            sw.WriteLine("\t{");
            sw.WriteLine($"\tphysProps.Add(\"ShapeFixtures\", new NSArray({shapeFixtures.Count}) {{");
            for (int i = 0; i < shapeFixtures.Count; i++)
            {
                NSArray outerarray = (NSArray)shapeFixtures[i];
                sw.WriteLine($"\t\tnew NSArray({outerarray.Count}) {{");
                checkForMoreNSArraysNested(outerarray);
                if (i == shapeFixtures.Count - 1) { sw.WriteLine("\t\t}"); }
                else { sw.WriteLine("\t\t},"); }
            }
            sw.WriteLine("\t\t});"); sw.WriteLine("\t}\n");
        }
    }

    private static void checkForMoreNSArraysNested(NSArray nsArray)
    {
        for (int i = 0; i < nsArray.Count; i++)
        {
            NSObject nestedObject = nsArray[i];
            if (nestedObject.GetType().Equals(typeof(NSArray)))
            {
                NSArray nestedarray = (NSArray)nestedObject;
                sw.Write("\t\t\tnew NSArray(" + nestedarray.Count + ") {");
                checkForMoreNSArraysNested(nestedarray);
                if (i == nsArray.Count - 1) { sw.WriteLine("}"); }
                else { sw.WriteLine("},"); }
            }
            if (nestedObject.GetType().Equals(typeof(NSNumber)))
            {
                NSNumber num = (NSNumber)nestedObject;
                double d = num.ToDouble();
                if (firstNumber) { sw.Write(d + ","); }
                else { sw.Write(d); }
                firstNumber = !firstNumber;
            }
        }
    }
}

using Claunia.PropertyList;
using System;
using System.IO;
using UnityEditor;
using UnityEngine;



public class AutoCoderFixtureFixer : MonoBehaviour
{
    static StreamWriter sw;
    static readonly string fileWriteLocation = "Levels/AutoCode.txt";
    static bool firstNumber = true;
    static bool pshsFile;
    static bool referenceMode;

    [MenuItem("Boom/AutoCode", false, 50)]
    static void AutoCode()
    {
        int option = EditorUtility.DisplayDialogComplex("Choose setting",
    "Codewriter for shapefixture stuff, Reference Mode - generates reference values",
    "Reference",
    "Cancel",
    "CodeWriter");

        switch (option)
        {
            // Reference Mode
            case 0:
                //;
                referenceMode = true;
                break;

            // Cancel.
            case 1:
                break;

            // CodeWriter
            case 2:
                referenceMode = false;
                break;

            default:
                Debug.LogError("Unrecognized option.");
                break;
        }
        string[] filters = { "boom extensions", "plhs,pshs", "All Files", "*" };
        string path = EditorUtility.OpenFilePanelWithFilters("Open boom file with ShapeFixtures", "", filters);
        //pshsFile = EditorUtility.DisplayDialog("PSHS File or PLHS File",
        //        "choose the file extension that you are using", "PSHS", "PLHS");
        pshsFile = path.Substring(path.Length - 4) == "pshs";
        
        if (path.Length != 0)
        {
            var fileContent = File.ReadAllBytes(path);
            NSObject obj = PropertyListParser.Parse(fileContent);
            if (obj is NSDictionary dict)
            {
                WriteTheArray((NSArray)dict["SPRITES_INFO"]);
                Debug.Log($"Writing Code to {fileWriteLocation}");
            }
            else
            {
                EditorUtility.DisplayDialog("Level not valid",
                    "The level file could not be read because the structure is invalid.", "OK");
            }
        }
    }
    private static void WriteTheArray(NSArray sprites)
    {
        //could probably save to somewhere else, but it's sort of a temp file
        Directory.CreateDirectory("./Levels");
        sw = File.CreateText(fileWriteLocation);
        try
        {
            if (referenceMode)
            {
                sw.WriteLine("public static Dictionary<string, float[]> gameObjectsReferenceSheet = new Dictionary<string, float[]>");
                sw.WriteLine("\t{");
            }
            for (int index = 0; index < sprites.Count; index++)
            {
                NSObject obj = sprites[index];
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
                    string fixturesWord, typeWord;
                    if (pshsFile) { fixturesWord = "Fixtures"; typeWord = "PhysicType"; }
                    else { fixturesWord = "ShapeFixtures"; typeWord = "Type"; }
                    if (referenceMode)
                    {
                        GenerateReferenceSheet(name, physicProperties, typeWord, index, sprites.Count);
                    } 
                    else
                    {
                        AnalyzePhysicsProperties(name, physicProperties, fixturesWord, typeWord);
                    }
             
                }
            }
            if (referenceMode) { sw.WriteLine("\t};\n"); }
        }
        finally
        {
            sw?.Dispose(); 
        }

    }

    private static void GenerateReferenceSheet(string name, NSDictionary physicProperties, string typeWord, int index, int spriteCount)
    {
        float density = (float)(NSNumber)physicProperties["Density"];
        float restitution = (float)(NSNumber)physicProperties["Restitution"];
        float angularVelocity = (float)(NSNumber)physicProperties["AngularVelocity"];
        float friction = (float)(NSNumber)physicProperties["Friction"];
        float type = (float)(NSNumber)physicProperties[typeWord];
        if(index == spriteCount - 1) 
        { 
            sw.WriteLine($"\t\t{{ \"{name}\" , new float[] {{ { density }f, { restitution }f, { angularVelocity }f, { friction }f, { type }f}} }}"); 
        }
        else
        {
            sw.WriteLine($"\t\t{{ \"{name}\" , new float[] {{ { density }f, { restitution }f, { angularVelocity }f, { friction }f, { type }f}} }},");
        }
    }

    private static void AnalyzePhysicsProperties(string name, NSDictionary physicProperties, string fixturesWord, string typeWord)
    {
        sw.WriteLine($"\tpublic static void {name}(NSDictionary physProps)");
        sw.WriteLine("\t{");
        ///Left here so incase I want to change how I reference sprites physics values.
        ////written in DRAFT format for better readability than normal base file
        //sw.WriteLine($"\t\tphysProps.Add(\"Density\", {(float)(NSNumber)physicProperties["Density"]});");
        //sw.WriteLine($"\t\tphysProps.Add(\"Restitution\", {(float)(NSNumber)physicProperties["Restitution"]});");
        //sw.WriteLine($"\t\tphysProps.Add(\"AngularVelocity\", {(float)(NSNumber)physicProperties["AngularVelocity"]});");
        //sw.WriteLine($"\t\tphysProps.Add(\"Friction\", {(float)(NSNumber)physicProperties["Friction"]});");
        //sw.WriteLine($"\t\tphysProps.Add(\"Type\", {(float)(NSNumber)physicProperties[typeWord]});");
        if (physicProperties.ContainsKey(fixturesWord))
        {
            NSArray shapeFixtures = (NSArray)physicProperties[fixturesWord];
            if (shapeFixtures.Count > 0)
            {
                sw.WriteLine($"\t\tphysProps.Add(\"ShapeFixtures\", new NSArray({shapeFixtures.Count}) {{");
                for (int i = 0; i < shapeFixtures.Count; i++)
                {
                    NSArray outerarray = (NSArray)shapeFixtures[i];
                    sw.WriteLine($"\t\t\tnew NSArray({outerarray.Count}) {{");
                    CheckForMoreNestedNSArrays(outerarray);
                    if (i == shapeFixtures.Count - 1) { sw.WriteLine("\t\t\t}"); }
                    else { sw.WriteLine("\t\t\t},"); }
                }
                sw.WriteLine("\t\t});"); //sw.WriteLine("\t}\n");
            }      
        }
        sw.WriteLine("\t}\n");
    }

    private static void CheckForMoreNestedNSArrays(NSArray nsArray)
    {
        for (int i = 0; i < nsArray.Count; i++)
        {
            NSObject nestedObject = nsArray[i];
            if (nestedObject.GetType().Equals(typeof(NSArray)))
            {
                NSArray nestedarray = (NSArray)nestedObject;
                sw.Write("\t\t\t\tnew NSArray(" + nestedarray.Count + ") {");
                CheckForMoreNestedNSArrays(nestedarray);
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

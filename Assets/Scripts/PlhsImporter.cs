using System.Collections.Generic;
using System.IO;
using System.Linq;
using Claunia.PropertyList;
using UnityEditor;
using UnityEngine;
using UnityEngine.U2D;

public class PlhsImporter : MonoBehaviour
{
    private static int multiplier = 50;
    //prefabs of ground because you can't access spriteshapecontrollers profile through script :/
    //can't use list or dictionary
    [SerializeField] static GameObject cityGroundPrefab;
    [SerializeField] GameObject factoryGroundPrefab;
    [SerializeField] GameObject jungleGroundPrefab;
    [SerializeField] GameObject egyptGroundPrefab;
    [SerializeField] GameObject StoneiceGroundPrefab;
    [SerializeField] GameObject EpyptBGPrefab;
    [SerializeField] GameObject stoneIceBGPrefab;

    [MenuItem("Boom/Import PLHS", false, 20)]
    static void ImportPlhs()
    {
        Debug.Log("Importing PLHS to Scene...");
        string path = EditorUtility.OpenFilePanel("Open boom level", "", "plhs");
        if (path.Length != 0)
        {
            var fileContent = File.ReadAllBytes(path);
            NSObject obj = PropertyListParser.Parse(fileContent);
            if (obj is NSDictionary dict)
            {
                LoadCamera((NSArray) ((NSDictionary) dict["ScenePreference"])["GameWorld"]);
                LoadSprites((NSArray) dict["SPRITES_INFO"]);
                if (dict.ContainsKey("BEZIER_INFO")) { LoadGround((NSArray) dict["BEZIER_INFO"]); }
            }
            else
            {
                EditorUtility.DisplayDialog("Level not valid",
                    "The level file could not be read because the structure is invalid.", "OK");
            }
        }
    }

    private static void LoadCamera(NSArray gameWorld)
    {
        // if (Camera.main != null)
        // {
        //     Camera.main.rect = new Rect(((NSNumber) gameWorld[0]).floatValue(), ((NSNumber) gameWorld[1]).floatValue(),
        //         ((NSNumber) gameWorld[2]).floatValue(), ((NSNumber) gameWorld[3]).floatValue());
        // }
        GameObject gameWorldObject = new GameObject();
        gameWorldObject.name = "GameWorld";
        RectTransform rectTransform = gameWorldObject.AddComponent<RectTransform>();
        float x = ((NSNumber) gameWorld[0]).floatValue() / multiplier;
        float y = ((NSNumber) gameWorld[1]).floatValue() / multiplier;
        float w = ((NSNumber) gameWorld[2]).floatValue() / multiplier;
        float h = ((NSNumber) gameWorld[3]).floatValue() / multiplier;
        rectTransform.pivot = Vector2.zero;
        rectTransform.position = new Vector3(x, -(h + y));
        rectTransform.sizeDelta = new Vector2(w, h);
    }

    private static void LoadSprites(NSArray sprites)
    {
        Dictionary<string, Sprite[]> spritesheets = new Dictionary<string, Sprite[]>();
        foreach (NSObject obj in sprites)
        {
            NSDictionary dict = (NSDictionary)obj;
            NSDictionary properties = (NSDictionary)dict["GeneralProperties"];


            GameObject newObj = new GameObject();
            newObj.name = properties["UniqueName"].ToString();
            SpriteRenderer spriteRenderer = newObj.AddComponent<SpriteRenderer>();
            string imageName = properties["Image"].ToString();
            // Cache the sprites for performance reasons
            if (!spritesheets.ContainsKey(imageName))
            {
                spritesheets.Add(imageName,
                    Resources.LoadAll<Sprite>($"Textures/{Path.GetFileNameWithoutExtension(imageName)}"));
            }

            spriteRenderer.sprite = spritesheets[imageName].Single(s => s.name == properties["SHName"].ToString());
            NSArray pos = (NSArray)properties["Position"];
            newObj.transform.position = new Vector3(((NSNumber)pos[0]).floatValue() / multiplier,
                -((NSNumber)pos[1]).floatValue() / multiplier, ((NSNumber)properties["ZOrder"]).floatValue());
            newObj.transform.Rotate(new Vector3(0, 0, -((NSNumber)properties["Angle"]).floatValue()));

            NSArray scale = (NSArray)properties["Scale"];
            newObj.transform.localScale = new Vector2((float)(NSNumber)scale[0], (float)(NSNumber)scale[1]);

            if (dict.ContainsKey("PhysicProperties"))
            {
                NSDictionary physProps = (NSDictionary)dict["PhysicProperties"];
                BoomPhysicsModifier BPM = newObj.AddComponent<BoomPhysicsModifier>();
                BPM.density = (float)(NSNumber)physProps["Density"]; 
                BPM.restitution = (float)(NSNumber)physProps["Restitution"];
                BPM.friction = (float)(NSNumber)physProps["Friction"];
                BPM.type = (int)(NSNumber)physProps["Type"];
                BPM.rotationSpeed = (float)(NSNumber)physProps["AngularVelocity"];
            }
        }

        // Unload the unused sprites?
    }

    private static void LoadGround(NSArray bigBezierArray)
    {
        //don't think this is an array, It is probably a dictionary for the load ground input parameters
        NSDictionary bezierDict = (NSDictionary)bigBezierArray[0];
        //instantiate at position of 
        GameObject groundObject = Instantiate(cityGroundPrefab);
        var spriteShapeRenderer = groundObject.GetComponent<SpriteShapeRenderer>();
        var spriteShapeController = groundObject.GetComponent<SpriteShapeController>();
        var spline = spriteShapeController.spline;
        //spriteShapeController
        groundObject.name = bezierDict["Image"].ToString().Substring(0, bezierDict["Image"].ToString().Length - 4);
    }
}
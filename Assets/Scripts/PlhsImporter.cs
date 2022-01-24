using System.Collections.Generic;
using System.IO;
using System.Linq;
using Claunia.PropertyList;
using UnityEditor;
using UnityEngine;
using UnityEngine.U2D;
using mattatz.Triangulation2DSystem;

public class PlhsImporter : MonoBehaviour
{
    private static int multiplier = 50;
    public static float triangulationThreshold = 20.5f;
    static string[] DRAFTLstrings = { "Density", "Restitution", "AngularVelocity", "Friction", "Type", "LinearVelocity" };
    //prefabs of ground because you can't access spriteshapecontrollers profile through script :/
    //can't use list or dictionary
    [SerializeField] static GameObject JungleGroundPrefab;
    [SerializeField] static GameObject JungleBGroundPrefab;
    [SerializeField] static GameObject CityGroundPrefab;
    [SerializeField] static GameObject CityGroundBGPrefab;
    [SerializeField] static GameObject StonesIcePrefab;
    [SerializeField] static GameObject FrozenBGPrefab;
    [SerializeField] static GameObject EgyptGroundPrefab;
    [SerializeField] static GameObject EgyptGroundBGPrefab;
    [SerializeField] static GameObject DesertGroundPrefab;
    [SerializeField] static GameObject FactoryGroundPrefab;
    [SerializeField] static GameObject FactoryGroundBGPrefab;
    [SerializeField] static GameObject WaterFillPrefab;
    [SerializeField] static GameObject QuicksandFillPrefab;

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
                foreach(string physicThing in DRAFTLstrings)
                {
                    if (physProps[physicThing].GetType().Equals(typeof(NSString)))
                    {
                        physProps[physicThing] = (NSNumber)float.Parse((string)(NSString)physProps[physicThing]);
                    }
                    switch (physicThing)
                    {
                        case "Density":
                            BPM.density = (float)(NSNumber)physProps[physicThing];
                            break;
                        case "Restitution":
                            BPM.restitution = (float)(NSNumber)physProps[physicThing];
                            break;
                        case "AngularVelocity":
                            BPM.rotationSpeed = (float)(NSNumber)physProps[physicThing];
                            break;
                        case "Friction":
                            BPM.friction = (float)(NSNumber)physProps[physicThing];
                            break;
                        case "Type":
                            BPM.type = (int)(NSNumber)physProps[physicThing];
                            break;
                        case "LinearVelocity":
                            NSArray linearSpeed = (NSArray)physProps["LinearVelocity"];
                            BPM.horizontalSpeed = (float)(NSNumber)linearSpeed[0];
                            BPM.verticalSpeed = (float)(NSNumber)linearSpeed[1];
                            break;
                        default:
                            Debug.Log(physicThing + " can't be added to the bpm script");
                            break;
                    }
                }
            }
        }

        // Unload the unused sprites?
    }

    private static void LoadGround(NSArray bigBezierArray)
    {
        //don't think this is an array, It is probably a dictionary for the load ground input parameters
        foreach (NSDictionary bezierDict in bigBezierArray)
        {
            GameObject groundObject = null;
            switch (bezierDict["Image"].ToString())
            {
                case "JungleGround.png":
                    if (JungleGroundPrefab != null)
                    {
                        groundObject = Instantiate(JungleGroundPrefab);
                    }
                    break;
                case "JungleBGround.png":
                    if (JungleBGroundPrefab != null)
                    {
                        groundObject = Instantiate(JungleBGroundPrefab);
                    }
                    break;
                case "CityGround.png":
                    if (CityGroundPrefab != null)
                    {
                        groundObject = Instantiate(CityGroundPrefab);
                    }
                    break;
                case "CityGroundBG.png":
                    if (CityGroundBGPrefab != null)
                    {
                        groundObject = Instantiate(CityGroundBGPrefab);
                    }
                    break;
                case "StonesIce.png":
                    if (StonesIcePrefab != null)
                    {
                        groundObject = Instantiate(StonesIcePrefab);
                    }
                    break;
                case "FrozenBG.png":
                    if (JungleGroundPrefab != null)
                    {
                        groundObject = Instantiate(FrozenBGPrefab);
                    }
                    break;
                case "EgyptGround.png":
                    if (JungleGroundPrefab != null)
                    {
                        groundObject = Instantiate(EgyptGroundPrefab);
                    }
                    break;
                case "EgyptGroundBG.png":
                    if (JungleGroundPrefab != null)
                    {
                        groundObject = Instantiate(EgyptGroundBGPrefab);
                    }
                    break;
                case "DesertGround.png":
                    if (JungleGroundPrefab != null)
                    {
                        groundObject = Instantiate(DesertGroundPrefab);
                    }
                    break;
                case "FactoryGround.png":
                    if (JungleGroundPrefab != null)
                    {
                        groundObject = Instantiate(FactoryGroundPrefab);
                    }
                    break;
                case "FactoryGroundBG.png":
                    if (JungleGroundPrefab != null)
                    {
                        groundObject = Instantiate(FactoryGroundBGPrefab);
                    }
                    break;
                case "WaterFill.png":
                    if (JungleGroundPrefab != null)
                    {
                        groundObject = Instantiate(WaterFillPrefab);
                    }
                    break;
                case "QuicksandFill.png":
                    if (JungleGroundPrefab != null)
                    {
                        groundObject = Instantiate(QuicksandFillPrefab);
                    }
                    break;
                default:
                    Debug.Log("Not a vowel");
                    break;
            }
            SpriteShapeRenderer spriteShapeRenderer;
            SpriteShapeController spriteShapeController;
            if (groundObject == null)
            {
                groundObject = new GameObject(bezierDict["UniqueName"].ToString());
                spriteShapeRenderer = groundObject.AddComponent<SpriteShapeRenderer>();
                spriteShapeController = groundObject.AddComponent<SpriteShapeController>();
            }
            else
            {
                groundObject.name = bezierDict["UniqueName"].ToString();
                spriteShapeRenderer = groundObject.GetComponent<SpriteShapeRenderer>();
                spriteShapeController = groundObject.GetComponent<SpriteShapeController>();
            }
            var spline = spriteShapeController.spline;
            NSArray curves = (NSArray)bezierDict["Curves"];
            for (int i = 0; i < curves.Count - 1; i++)
            {
                NSDictionary pointsDict = (NSDictionary)curves[i];
                NSArray endPointArray = (NSArray)pointsDict["EndPoint"];
                float offsettedPointX = (float)(NSNumber)endPointArray[0] / multiplier;
                float offsettedPointY = (float)(NSNumber)endPointArray[1] / multiplier;
                Vector3 endPointVector = new Vector3(offsettedPointX, offsettedPointY);
                spline.InsertPointAt(i, endPointVector);
            }
        }
    }
}
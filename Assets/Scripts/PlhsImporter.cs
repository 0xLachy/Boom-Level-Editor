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
            spriteRenderer.color = new Color(1, 1, 1, (float)(NSNumber)properties["Opacity"]);

            if ((int)(NSNumber)properties["Tag"] != 0)
            {
                switch ((int)(NSNumber)properties["Tag"])
                {
                    case 2:
                        newObj.tag = "wheely";
                        break;
                    case 23:
                        newObj.tag = "bigWheel";
                        break;
                    case 5:
                        newObj.tag = "spike";
                        break;
                    case 19:
                        newObj.tag = "gate";
                        break;
                    case 35:
                        newObj.tag = "rightflipper";
                        break;
                    default:
                        Debug.Log("The object with the tag: " + (int)(NSNumber)properties["Tag"] + "needs to be added to script");
                        break;
                }
            }

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
                    Debug.Log("can't find prefab for the image " + bezierDict["Image"].ToString());
                    break;
            }
            SpriteShapeRenderer spriteShapeRenderer;
            SpriteShapeController spriteShapeController;
            if (groundObject == null)
            {
                groundObject = new GameObject(bezierDict["UniqueName"].ToString());
                spriteShapeRenderer = groundObject.AddComponent<SpriteShapeRenderer>();
                spriteShapeController = groundObject.AddComponent<SpriteShapeController>();
                ColourSpriteRenderer(bezierDict["Image"].ToString(), ref spriteShapeRenderer);
            }
            else
            {
                groundObject.name = bezierDict["UniqueName"].ToString();
                spriteShapeRenderer = groundObject.GetComponent<SpriteShapeRenderer>();
                spriteShapeController = groundObject.GetComponent<SpriteShapeController>();
            }
            if (bezierDict["Image"].ToString().Contains("BG"))
            {
                spriteShapeRenderer.sortingOrder = -1;
            }
            groundObject.transform.position = new Vector3(0, 0, (float)(NSNumber)bezierDict["ZOrder"]);

            var spline = spriteShapeController.spline;
            NSArray curves = (NSArray)bezierDict["Curves"];
            for (int i = 0; i < curves.Count; i++)
            {
                NSDictionary pointsDict = (NSDictionary)curves[i];
                NSArray endPointArray = (NSArray)pointsDict["EndPoint"];
                float offsettedPointX = (float)(NSNumber)endPointArray[0] / multiplier;
                float offsettedPointY = -(float)(NSNumber)endPointArray[1] / multiplier;
                Vector3 endPointVector = new Vector3(offsettedPointX, offsettedPointY);
                
                if(i > 3)
                {
                    spline.InsertPointAt(i, endPointVector);
                }
                else
                {
                    spline.SetPosition(i, endPointVector);
                    
                }
            }
        }
    }

    static void ColourSpriteRenderer(string groundName, ref SpriteShapeRenderer groundSSR)
    {

        switch (groundName)
        {
            case "JungleGround.png":
                groundSSR.color = new Color32(34, 72, 35, 255);
                break;
            case "JungleBGround.png":
                groundSSR.color = new Color32(99, 99, 64, 255);
                break;
            case "CityGround.png":
                groundSSR.color = new Color32(41, 34, 72, 255);
                break;
            case "CityGroundBG.png":
                groundSSR.color = new Color32(41, 56, 106, 255);
                break;
            case "StonesIce.png":
                groundSSR.color = new Color32(157, 202, 233, 255);
                break;
            case "FrozenBG.png":
                groundSSR.color = new Color32(72, 110, 137, 255);
                break;
            case "EgyptGround.png":
                groundSSR.color = new Color32(192, 155, 90, 255);
                break;
            case "EgyptGroundBG.png":
                groundSSR.color = new Color32(106, 66, 51, 255);
                break;
            case "DesertGround.png":
                groundSSR.color = new Color32(192, 155, 90, 255);
                break;
            case "FactoryGround.png":
                groundSSR.color = new Color32(64, 26, 79, 255);
                break;
            case "FactoryGroundBG.png":
                groundSSR.color = new Color32(81, 64, 99, 255);
                break;
            case "WaterFill.png":
                groundSSR.color = new Color32(133, 182, 255, 255);
                break;
            case "QuicksandFill.png":
                groundSSR.color = Color.yellow;
                break;
            default:
                Debug.Log("can't find colour for the image " + groundName);
                break;
        }
    }
}
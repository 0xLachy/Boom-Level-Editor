﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.IO;
using Claunia.PropertyList;
using mattatz.Triangulation2DSystem;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.U2D;

//[RequireComponent(typeof(CogFixer))]
public class PlhsGenerator : MonoBehaviour
{
    private static int multiplier = 50;
    public static float triangulationThreshold = 20.5f;
    public static float zoomValue = 1.0f;
    
    [MenuItem("Boom/Export PLHS %g", false, 0)]
    static void ExportPlhs()
    {
        Debug.Log("Exporting Scene to PLHS...");
        CreatePlist();
    }

    private static void CreatePlist()
    {
        //HttpListenerExample.HttpServer.listener?.Close();
        // Creating the root object
        var root = new NSDictionary();
        root.Add("Author", "Bogdan Vladu");
        root.Add("PARALLAX_INFO", new NSArray(0));
        var sprites = new NSArray();
        var beziers = new NSArray();
        // Convert all scene game objects to an array of sprites
        GameObject[] allObjects = FindObjectsOfType<GameObject>();

        // Not sure if doable
        //ConvertMovingPlatformParentNames(allObjects);

        foreach (GameObject gameObject in allObjects)
        {
            if (gameObject.activeInHierarchy)
            {
                if (gameObject.GetComponent<SpriteRenderer>() != null)
                {
                    sprites.Add(GameObjectToNSDictionary(gameObject));
                }
                else if (gameObject.GetComponent<SpriteShapeController>() != null)
                {
                    beziers.Add(BezierToNSDictionary(gameObject));
                }
            }
        }
        for (int index = 0; index < sprites.Count; index++)
        {
            NSObject obj = sprites[index];
            NSDictionary dict = (NSDictionary)obj;
            if (dict.ContainsKey("GeneralProperties"))
            {
                NSDictionary generalProperties = (NSDictionary)dict["GeneralProperties"];
                if (generalProperties["SHName"].ToString() == "cage_fg")
                {
                    //this probably will break if you apply physics mods to the cage
                    NSDictionary cageDict = dict;
                    sprites.RemoveAt(index);
                    sprites.Add(cageDict);
                }
            }
        }
        root.Add("SPRITES_INFO", sprites);
        root.Add("LoadedImages", GetLoadedImages());
        root.Add("LHVersion", "1.4.7");
        root.Add("BEZIER_INFO", beziers);
        root.Add("Gravity", new NSArray() { 0.0, -10.0 });
        root.Add("CreatedWith", "LevelHelper");
        root.Add("JOINTS_INFO", new NSArray());
        root.Add("ScenePreference", GetScenePreferences());
        // Save the property list
        string sceneName = SceneManager.GetActiveScene().name;
        root.Add("CustomLevelName", sceneName);
        Directory.CreateDirectory("./Levels");
        PropertyListParser.SaveAsXml(root, new FileInfo("Levels/" + sceneName + ".plhs"));
        Debug.Log("Saving level to: Levels/" + sceneName + ".plhs");
    }

    //TODO maybe add this in the outer for loop because it seems unoptimised
    // if there are grouping objects (ones without sprite renderers) then give the children unique names, and give them the _trigger and _to endings
    private static void ConvertMovingPlatformParentNames(GameObject[] allObjects)
    {
        foreach (GameObject gameObject in allObjects)
        {
            // if it isn't a sprite, then loop through it's children and stuff
            if(!gameObject.TryGetComponent<SpriteRenderer>(out var sr))
            {
                int endIndex = gameObject.name.LastIndexOf('_');
                if (endIndex == -1) continue;

                String append = gameObject.name.Substring(endIndex).ToLower();
                for (int i = 0; i < gameObject.transform.childCount; i++)
                {
                    if(i == 0)
                    {
                        // if they already have the append, the other children probably will have too
                        if (gameObject.transform.GetChild(i).name.Contains(append)) break;
                    }
                    gameObject.transform.GetChild(i).name += $"{i}{append}";
                }
            }
        }
    }

    private static NSDictionary BezierToNSDictionary(GameObject gameObject)
    {
        var bezier = new NSDictionary();
        var spriteShapeController = gameObject.GetComponent<SpriteShapeController>();

        if (gameObject.name.Length >= 7 && gameObject.name.Substring(0, 7) == "EgyptBG")
        {
            bezier.Add("TagName", "LHTAG_STONE_GROUND");
            bezier.Add("IsSenzor", false);
            bezier.Add("Tag", 24);
            bezier.Add("Friction", 1.0);
            bezier.Add("Image", "EgyptGroundBG.png");
            bezier.Add("PhysicType", 3);
            //if zOrder is anything but 0 it will cause problems....
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y);
        }
        else if (gameObject.name.Length >= 11 && gameObject.name.Substring(0, 11) == "EgyptGround")
        {
            bezier.Add("TagName", "LHTAG_STONE_GROUND");
            bezier.Add("IsSenzor", false);
            bezier.Add("Tag", 24);
            bezier.Add("Friction", 1.0);
            bezier.Add("Image", "EgyptGround.png");
            bezier.Add("PhysicType", 0);
        }
        else if (gameObject.name.Length >= 8 && gameObject.name.Substring(0,8) == "FrozenBG")
        {
            bezier.Add("TagName", "LHTAG_STONE_GROUND");
            bezier.Add("IsSenzor", false);
            bezier.Add("Tag", 24);
            bezier.Add("Friction", 1.0);
            bezier.Add("Image", "FrozenBG.png");
            bezier.Add("PhysicType", 3);
        }
        else if (gameObject.name.Length >= 9 && gameObject.name.Substring(0,9) == "StonesIce")
        {
            bezier.Add("TagName", "LHTAG_STONE_GROUND");
            bezier.Add("IsSenzor", false);
            bezier.Add("Tag", 24);
            bezier.Add("Friction", 1.0);
            bezier.Add("Image", "StonesIce.png");
            bezier.Add("PhysicType", 0);
        }
        else if (gameObject.name.Length >= 12 && gameObject.name.Substring(0, 12) == "JungleGround")
        {
            bezier.Add("TagName", "LHTAG_STONE_GROUND");
            bezier.Add("IsSenzor", false);
            bezier.Add("Tag", 24);
            bezier.Add("Friction", 1.0);
            bezier.Add("Image", "JungleGround.png");
            bezier.Add("PhysicType", 0);
        }
        else if (gameObject.name.Length >= 4 && gameObject.name.Substring(0, 4) == "zoom")
        {
            bezier.Add("TagName", "LHTAG_STONE_GROUND");
            bezier.Add("IsSenzor", false);
            bezier.Add("Tag", 24);
            bezier.Add("Friction", 1.0);
            bezier.Add("Image", "");
            bezier.Add("PhysicType", 0);
        }
        else if (gameObject.name.Length >= 5 && gameObject.name.Substring(0, 5) == "Water")
        {
            bezier.Add("TagName", "LHTAG_WATER");
            bezier.Add("IsSenzor", true);
            bezier.Add("Tag", 13);
            bezier.Add("Friction", 0.2);
            bezier.Add("Image", "WaterFill.png");
            bezier.Add("PhysicType", 0);
        }
        else if (gameObject.name.Length >= 9 && gameObject.name.Substring(0, 9) == "quicksand")
        {
            bezier.Add("TagName", "LHTAG_QUICKSAND");
            bezier.Add("IsSenzor", true);
            bezier.Add("Tag", 44);
            bezier.Add("Friction", 0.2);
            bezier.Add("Image", "QuicksandFill.png");
            bezier.Add("PhysicType", 0);
        }
        else //default
        {
            bezier.Add("TagName", "LHTAG_STONE_GROUND");
            bezier.Add("IsSenzor", false);
            bezier.Add("Tag", 24);
            bezier.Add("Friction", 1.0);
            bezier.Add("Image", spriteShapeController.spriteShape.fillTexture.name + ".png");
            bezier.Add("PhysicType", 0);
        }

        bezier.Add("IsSimpleLine", true);
        bezier.Add("Color", new NSArray(4) { 1.0, 1.0, 1.0, 1.0 });
        bezier.Add("IsTile", true);
        bezier.Add("IsPath", false);
        bezier.Add("Density", 0.2);
        bezier.Add("Mask", 65535);
        bezier.Add("GravityScale", 1.0);
        bezier.Add("Group", 0);
        bezier.Add("IsDrawable", true);

        var spline = spriteShapeController.spline;


        //Calling Spline.GetPointCount can crash unity
        //however it may only occur on the second call, so SPC may be redundant now.
        // error if SPC count != Actual spline count!!
        spline.GetPointCount();
        int pointCount = gameObject.TryGetComponent<SplinePointCounter>(out var SPC) ? SPC.pointCount : spline.GetPointCount();
        Vector2[] points = new Vector2[pointCount];

        //int testing = spline
        for (int i = 0; i < pointCount; i++)
        {
            //Vector3 vekkie = gameObject.transform.TransformPoint(spline.GetPosition(i));
            //Debug.Log("X:" + vekkie.x + " Y:" + vekkie.y);
            //Debug.Log("X: " + (gameObject.transform.position.x + spline.GetPosition(i).x) + " Y: " + (gameObject.transform.position.y + spline.GetPosition(i).y));
            var newX = (gameObject.transform.position.x + spline.GetPosition(i).x) * multiplier;
            var newY = -(gameObject.transform.position.y + spline.GetPosition(i).y) * multiplier;
            points[i] = new Vector2(newX, newY);
        }
        //testing with a debug.Log statement here, it seems that the infinte load happens before this
        Polygon2D polygon = Polygon2D.Contour(points);
        Triangulation2D triangulation = new Triangulation2D(polygon, triangulationThreshold);
        var triangles = triangulation.Triangles;

        var tileVertices = new NSArray();
        foreach (var triangle in triangles)
        {
            var triangleArr = new NSArray()
            {
                new NSArray() {triangle.a.Coordinate.x, triangle.a.Coordinate.y},
                new NSArray() {triangle.b.Coordinate.x, triangle.b.Coordinate.y},
                new NSArray() {triangle.c.Coordinate.x, triangle.c.Coordinate.y}
            };
            tileVertices.Add(triangleArr);
        }

        bezier.Add("TileVertices", tileVertices);
        bezier.Add("UniqueName", gameObject.name);
        bezier.Add("CanSleep", true);
        bezier.Add("LineWidth", 1.0);
        bezier.Add("ZOrder", (int)gameObject.transform.position.z);
        bezier.Add("Category", 1);

        // Add curves for collisions
        var curves = new NSArray();
        for (var i = 1; i < spline.GetPointCount(); i++)
        {
            curves.Add(PointsToCurve(points[i - 1], points[i]));
        }
        // Connect last point with first
        curves.Add(PointsToCurve(points[points.Length - 1], points[0]));
        bezier.Add("Curves", curves);
        bezier.Add("LineColor", bezier.Get("Color"));
        bezier.Add("Restitution", 0.0);
        bezier.Add("IsClosed", true);
        return bezier;
    }

    private static NSDictionary PointsToCurve(Vector2 startPoint, Vector2 endPoint)
    {
        var controlPoint = new NSArray(2) { (startPoint.x + endPoint.x) / 2, (startPoint.y + endPoint.y) / 2 };
        var dict = new NSDictionary();
        dict.Add("EndControlPoint", controlPoint);
        dict.Add("StartControlPoint", controlPoint);
        dict.Add("EndPoint", new NSArray(2) { endPoint.x, endPoint.y });
        dict.Add("StartPoint", new NSArray(2) { startPoint.x, startPoint.y });
        return dict;
    }

    private static NSDictionary GetScenePreferences()
    {
        var dict = new NSDictionary();
        dict.Add("ScreenSize", 1);
        dict.Add("PanValue",
            new NSArray()
                {Camera.main.transform.position.x * multiplier, -Camera.main.transform.position.y * multiplier});
        dict.Add("SafeFrame", new NSArray() { 480.0, 320.0 });
        dict.Add("ZoomValue", zoomValue);
        dict.Add("GameWorld", GetCameraBounds());
        dict.Add("BackgroundColor", new NSArray() { 0.631373, 0.921569, 0.976471, 0.0 });
        dict.Add("ProjectName", "Boom!");
        return dict;
    }

    private static NSArray GetCameraBounds()
    {
        var arr = new NSArray();
        float camSize = Camera.main.orthographicSize;
        arr.Add((Camera.main.transform.position.x - camSize / 2) * multiplier);
        arr.Add((-Camera.main.transform.position.y - camSize / 2) * multiplier);
        arr.Add((Camera.main.transform.position.x + camSize / 2) * multiplier);
        arr.Add((-Camera.main.transform.position.y + camSize / 2) * multiplier + 500);
        return arr;
    }

    private static NSDictionary GameObjectToNSDictionary(GameObject gameObject)
    {
        var dict = new NSDictionary();
        var genProps = new NSDictionary();
        var physProps = new NSDictionary();
        SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer>();
        Color color = sr.color; //for opacity later, not used for color as it has no effect
        Sprite sprite = sr.sprite;
        //Edit to add gates and water and catch short string errors
        if (sprite.name.Substring(0, 3) == "box")
        {
            genProps.Add("TagName", "DEFAULT");
            genProps.Add("Tag", 0);
            genProps.Add("Opacity", color.a);
        }
        else if (gameObject.name.Length >= 4 && gameObject.name.Substring(0, 4) == "GATE" || gameObject.tag == "gate")
        {
            genProps.Add("TagName", "LHTAG_PICKUP_GATE");
            genProps.Add("Tag", 19);
            genProps.Add("Opacity", color.a);
        }
        else UnityTagToBoomTagInGame(gameObject, genProps, sprite, color);
        genProps.Add("Color", new NSArray(4) { color.r, color.g, color.b, 0.0 });
        genProps.Add("UV", new NSArray(4) { 0.0, 0.0, 0.0, 0.0 });


        int angle = (int)Quaternion.Inverse(gameObject.transform.rotation.normalized).eulerAngles.z;
        genProps.Add("SHName", sprite.name);
        genProps.Add("Image", sprite.texture.name + ".png");
        genProps.Add("SHScene", sprite.texture.name + ".pshs");
        genProps.Add("Angle", angle);
        genProps.Add("Size", new NSArray(2) { sprite.rect.width / 2, sprite.rect.height / 2 });
        genProps.Add("UniqueName", gameObject.name);
        genProps.Add("Position",
            new NSArray(2)
                {gameObject.transform.position.x * multiplier, -gameObject.transform.position.y * multiplier});
        if (gameObject.tag == "noDraw") { genProps.Add("IsDrawable", false); } else { genProps.Add("IsDrawable", true); };
        genProps.Add("IsInParallax", false);
        genProps.Add("Scale", new NSArray(2) { gameObject.transform.localScale.x, gameObject.transform.localScale.y });
        genProps.Add("ZOrder", (int)gameObject.transform.position.z);
        genProps.Add("Locked", false);

        var anim = gameObject.GetComponent<BoomAnimation>();
        if (anim != null)
        {
            //BoomAnimation anim = animations[sprite.name];
            genProps.Add("AnimRepetitions", anim.AnimRepetitions);
            genProps.Add("AnimAtStart", anim.AnimAtStart);
            genProps.Add("AnimSpeed", anim.AnimSpeed);
            genProps.Add("AnimName", anim.AnimName);
            genProps.Add("AnimLoop", anim.AnimLoop);
        }
        else
        {
            if (sprite.name.Length < 5 || (sprite.name.Length >= 5 && sprite.name.Substring(0, 5) != "water"))
            { 
                genProps.Add("AnimRepetitions", 0);
                genProps.Add("AnimAtStart", false);
                genProps.Add("AnimSpeed", 0.0);
                genProps.Add("AnimName", "");
                genProps.Add("AnimLoop", false);
            }
            else
            {
                genProps.Add("AnimRepetitions", 1);
                genProps.Add("AnimAtStart", true);
                genProps.Add("AnimSpeed", 0.06);
                genProps.Add("AnimName", "Water");
                genProps.Add("AnimLoop", true);
            }

        }
        if (!gameObject.TryGetComponent<BoomPhysicsModifier>(out var BPM))
        {
            BPM = gameObject.GetComponentInParent<BoomPhysicsModifier>();
        }

        if (BPM)
        {
            // give it the moving platform effect if ticked, tag method will also work
            if (BPM.isMovingPlatform)
            {
                genProps["TagName"] = new NSString("LHTAG_MOVING_FLAT");
                genProps["Tag"] = new NSNumber(46);
                genProps["Opacity"] = new NSNumber(color.a);
            }

            if (BPM.use0DRAFT)
            {
                physProps.Add("Density", BPM.density);
                physProps.Add("Restitution", BPM.restitution);
                physProps.Add("AngularVelocity", BPM.rotationSpeed);
                physProps.Add("Friction", BPM.friction);
                physProps.Add("Type", BPM.type);
                physProps.Add("IsCircle", BPM.isCircle);
            }
            else
            {
                if (BPM.density == 0) { AddDefaultValueFromRefScript(physProps, sprite.name, "Density"); }
                else
                {
                    physProps.Add("Density", BPM.density);
                }

                if (BPM.restitution == 0) { AddDefaultValueFromRefScript(physProps, sprite.name, "Restitution"); }
                else
                {
                    physProps.Add("Restitution", BPM.restitution);
                }

                if (BPM.rotationSpeed == 0) { AddDefaultValueFromRefScript(physProps, sprite.name, "AngularVelocity"); }
                else
                {
                    physProps.Add("AngularVelocity", BPM.rotationSpeed);
                }

                if (BPM.friction == 0) { AddDefaultValueFromRefScript(physProps, sprite.name, "Friction"); }
                else
                {
                    physProps.Add("Friction", BPM.friction);
                }

                if (BPM.type == 0) { AddDefaultValueFromRefScript(physProps, sprite.name, "Type"); }
                else
                {
                    physProps.Add("Type", BPM.type);
                }

                if ((sprite.name.Length >= 4) && (sprite.name.Substring(0, 4) == "bomb" || sprite.name.Substring(0, 4) == "ball" || sprite.name.Substring(0, 4) == "coin"))
                {
                    physProps.Add("IsCircle", true);
                }

            }

            physProps.Add("Mask", BPM.mask);
            physProps.Add("Group", BPM.group);
            physProps.Add("CanSleep", BPM.canSleep);
            physProps.Add("Category", BPM.category);
            physProps.Add("IsSensor", BPM.isSensor);
            physProps.Add("FixedRot", BPM.lockRotation);
            physProps.Add("GravityScale", BPM.gravity);
            physProps.Add("LinearVelocity", new NSArray(2) { BPM.horizontalSpeed, BPM.verticalSpeed });
            physProps.Add("LinearDamping", BPM.linearDampening);
            if (BPM.ShapePositionOffsett) { physProps.Add("ShapePositionOffset", new NSArray(2) { 0.000000, 0.000000 }); }
            if (BPM.ShapeBorder) { physProps.Add("ShapeBorder", new NSArray(2) { 0.000000, 0.000000 }); }

            if (BPM.customShapeFixtures)
            {
                BPM.CreateCustomFixtures(physProps);
            }
            else
            {
                //adding shapefixtures by name
                Type type = typeof(ShapeFixtures);
                MethodInfo method = type.GetMethod(sprite.name);
                ShapeFixtures shapeFixtures = new ShapeFixtures();
                try
                {
                    method.Invoke(shapeFixtures, new object[] { physProps });
                }
                catch (NullReferenceException)
                {
                    Debug.Log($"{sprite.name} is missing a shape fixtures reference, the border will be" +
                        $" rectangle and may not fit properly, Unity editor name {gameObject.name}");
                }
            }
            
            dict.Add("PhysicProperties", physProps);
        }

        //if (gameObject.transform.parent.transform.parent != null &&
        //        gameObject.transform.parent.transform.parent.tag == "ParentSpinner"
        //        || gameObject.transform.parent != null && gameObject.transform.parent.tag == "ParentSpinner" && rotationComponent == null)
        //{
        //    var childRotator = gameObject.AddComponent<BoomRotator>();
        //    if (gameObject.transform.parent.transform.parent != null)
        //    {
        //        var grandparentRotation = gameObject.transform.parent.GetComponentInParent<BoomRotator>();
        //        childRotator.rotationSpeed = grandparentRotation.rotationSpeed;
        //    }
        //    else if (gameObject.transform.parent != null)
        //    {
        //        var parentRotation = gameObject.GetComponentInParent<BoomRotator>();
        //        childRotator.rotationSpeed = parentRotation.rotationSpeed;
        //    }

        //}

        dict.Add("GeneralProperties", genProps);
        return dict;
    }

    private static void AddDefaultValueFromRefScript(NSDictionary physProps, string spriteName, string ValueNameToAdd)
    {
        //TODO why not just use dictionary???
        int retrievingIndex = 1;
        switch (ValueNameToAdd)
        {
            case "Density":
                retrievingIndex = 0;
                break;
            case "Restitution":
                retrievingIndex = 1;
                break;
            case "AngularVelocity":
                retrievingIndex = 2;
                break;
            case "Friction":
                retrievingIndex = 3;
                break;
            case "Type":
                retrievingIndex = 4;
                break;
            default:
                Debug.Log($"couldn't add {ValueNameToAdd} to GORS with spritename {spriteName} index {retrievingIndex}");
                return;
        }
        if (DefaultValuesReferences.GORS.TryGetValue(spriteName, out decimal[] spriteInfo))
        {
            physProps.Add(ValueNameToAdd, /*String.Format("{0:0.000000}"makes string :(,*/ (double)spriteInfo[retrievingIndex]);//); 
        } 
        else
        {
            Debug.Log($"The Reference in GORS for {spriteName} doesn't exist");
        }
    }

    private static void UnityTagToBoomTagInGame(GameObject gameObject, NSDictionary genProps, Sprite sprite, Color color)
    {
        //for some reason quick actions and refactorings wants to put this in here, don't know why, fix later.
        if (gameObject.name.Length >= 5 && gameObject.name.Substring(0, 5) == "bigwh")
        {
            genProps.Add("TagName", "DEFAULT");
            genProps.Add("Tag", 23);
            genProps.Add("Opacity", color.a);
        }
        else if (gameObject.transform.parent != null && gameObject.transform.parent.tag == "sandstone" || gameObject.tag == "sandstone")
        {
            genProps.Add("TagName", "LHTAG_SANDSTONE_BLOCK");
            genProps.Add("Tag", 18);
            genProps.Add("Opacity", color.a);
        }
        else if (gameObject.transform.parent != null && gameObject.transform.parent.tag == "bomb" || gameObject.tag == "bomb")
        {
            genProps.Add("TagName", "LHTAG_BOMB");
            genProps.Add("Tag", 17);
            genProps.Add("Opacity", color.a);
        }
        else if (gameObject.transform.parent != null && gameObject.transform.parent.tag == "star" || gameObject.tag == "star")
        {
            genProps.Add("TagName", "LHTAG_STAR");
            genProps.Add("Tag", 54);
            genProps.Add("Opacity", color.a);
        }
        else if (gameObject.transform.parent != null && gameObject.transform.parent.tag == "spike" || gameObject.tag == "spike")
        {
            genProps.Add("TagName", "LHTAG_SPIKES");
            genProps.Add("Tag", 5);
            genProps.Add("Opacity", color.a);
        }
        else if (gameObject.transform.parent != null && gameObject.transform.parent.tag == "wheely" || gameObject.tag == "wheely")
        {
            genProps.Add("TagName", "LHTAG_WHEELY");
            genProps.Add("Tag", 2);
            genProps.Add("Opacity", color.a);
        }
        else if (gameObject.transform.parent != null && gameObject.transform.parent.tag == "rocket" || gameObject.tag == "rocket")
        {
            genProps.Add("TagName", "LHTAG_ROCKET");
            genProps.Add("Tag", 9);
            genProps.Add("Opacity", color.a);
        }
        else if (gameObject.transform.parent != null && gameObject.transform.parent.tag == "cage" || gameObject.tag == "cage")
        {
            genProps.Add("TagName", "LHTAG_CAGE");
            genProps.Add("Tag", 20);
            genProps.Add("Opacity", color.a);
        }
        else if (gameObject.transform.parent != null && gameObject.transform.parent.tag == "boosttunnel" || gameObject.tag == "boosttunnel")
        {
            genProps.Add("TagName", "LHTAG_BOOST_TUNNEL");
            genProps.Add("Tag", 29);
            genProps.Add("Opacity", color.a);
        }
        else if (gameObject.transform.parent != null && gameObject.transform.parent.tag == "leftflipper" || gameObject.tag == "leftflipper")
        {
            genProps.Add("TagName", "LHTAG_FLIPPER_LEFT");
            genProps.Add("Tag", 34);
            genProps.Add("Opacity", color.a);
        }
        else if (gameObject.transform.parent != null && gameObject.transform.parent.tag == "rightflipper" || gameObject.tag == "rightflipper")
        {
            genProps.Add("TagName", "LHTAG_FLIPPER_RIGHT");
            genProps.Add("Tag", 35);
            genProps.Add("Opacity", color.a);
        }
        else if (gameObject.transform.parent != null && gameObject.transform.parent.tag == "bumper" || gameObject.tag == "bumper")
        {
            genProps.Add("TagName", "LHTAG_BUMPER");
            genProps.Add("Tag", 31);
            genProps.Add("Opacity", color.a);
        }
        else if (gameObject.transform.parent != null && gameObject.transform.parent.tag == "lollipop" || gameObject.tag == "lollipop")
        {
            genProps.Add("TagName", "LHTAG_LOLLIPOP");
            genProps.Add("Tag", 36);
            genProps.Add("Opacity", color.a);
        }
        else if (gameObject.transform.parent != null && gameObject.transform.parent.tag == "plastic" || gameObject.tag == "plastic")
        {
            genProps.Add("TagName", "LHTAG_PLASTIC_BLOCK");
            genProps.Add("Tag", 37);
            genProps.Add("Opacity", color.a);
        }
        else if (gameObject.transform.parent != null && gameObject.transform.parent.tag == "springboard" || gameObject.tag == "springboard")
        {
            genProps.Add("TagName", "LHTAG_SPRINGBOARD");
            genProps.Add("Tag", 27);
            genProps.Add("Opacity", color.a);
        }
        else if (gameObject.transform.parent != null && gameObject.transform.parent.tag == "glassball" || gameObject.tag == "glassball")
        {
            genProps.Add("TagName", "LHTAG_GLASS_BALL");
            genProps.Add("Tag", 50);
            genProps.Add("Opacity", color.a);
        }
        else if (gameObject.transform.parent != null && gameObject.transform.parent.tag == "firebowl" || gameObject.tag == "firebowl")
        {
            genProps.Add("TagName", "LHTAG_FIRE_BOWL");
            genProps.Add("Tag", 43);
            genProps.Add("Opacity", color.a);
        }
        else if (gameObject.transform.parent != null && gameObject.transform.parent.tag == "coin" || gameObject.tag == "coin")
        {
            genProps.Add("TagName", "LHTAG_PICKUP");
            genProps.Add("Tag", 4);
            genProps.Add("Opacity", color.a);
        }
        else if (gameObject.transform.parent != null && gameObject.transform.parent.tag == "ball" || gameObject.tag == "ball")
        {
            genProps.Add("TagName", "LHTAG_BALL");
            genProps.Add("Tag", 22);
            genProps.Add("Opacity", color.a);
        }
        else if (gameObject.transform.parent != null && gameObject.transform.parent.tag == "movingplatform" || gameObject.tag == "movingplatform")
        {
            genProps.Add("TagName", "LHTAG_MOVING_FLAT");
            genProps.Add("Tag", 46);
            genProps.Add("Opacity", color.a);
        }
        else if (gameObject.name.Length >= 5 && sprite.name.Substring(0, 5) == "water")
        {
            genProps.Add("TagName", "LHTAG_WATER");
            genProps.Add("Tag", 13);
            genProps.Add("Opacity", 0.8);
        }
        else
        {
            genProps.Add("TagName", "DEFAULT");
            genProps.Add("Tag", 0);
            genProps.Add("Opacity", color.a);
        }
    }

    private static NSArray GetLoadedImages()
    {
        var arr = new NSArray();
        for (int i = 0; i < 19; i++)
        {
            var dict = new NSDictionary { { "OrderZ", 0 } };
            arr.Add(dict);
        }

        ((NSDictionary)arr[0]).Add("Image", "CityGround.png");
        ((NSDictionary)arr[1]).Add("Image", "CityGroundBG.png");
        ((NSDictionary)arr[2]).Add("Image", "DesertGround.png");
        ((NSDictionary)arr[3]).Add("Image", "EgyptGround.png");
        ((NSDictionary)arr[4]).Add("Image", "EgyptGroundBG.png");
        ((NSDictionary)arr[5]).Add("Image", "FactoryGround.png");
        ((NSDictionary)arr[6]).Add("Image", "FactoryGroundBG.png");
        ((NSDictionary)arr[7]).Add("Image", "FrozenBG.png");
        ((NSDictionary)arr[8]).Add("Image", "GameObjectsBG.png");
        ((NSDictionary)arr[9]).Add("Image", "JungleBGround.png");
        ((NSDictionary)arr[10]).Add("Image", "JungleGround.png");
        ((NSDictionary)arr[11]).Add("Image", "QuicksandFill.png");
        ((NSDictionary)arr[12]).Add("Image", "StonesIce.png");
        ((NSDictionary)arr[13]).Add("Image", "TestGround.png");
        ((NSDictionary)arr[14]).Add("Image", "WaterFill.png");
        ((NSDictionary)arr[15]).Add("Image", "WheelBit.png");
        ((NSDictionary)arr[16]).Add("Image", "Tracks.png");
        ((NSDictionary)arr[16])["OrderZ"] = (NSNumber)1;
        ((NSDictionary)arr[17]).Add("Image", "GameObjects.png");
        ((NSDictionary)arr[17])["OrderZ"] = (NSNumber)2;
        ((NSDictionary)arr[18]).Add("Image", "GameObjectsFG.png");
        ((NSDictionary)arr[18])["OrderZ"] = (NSNumber)6;

        return arr;
    }
}
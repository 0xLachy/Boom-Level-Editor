using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Claunia.PropertyList;
using mattatz.Triangulation2DSystem;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.U2D;

public class PlhsGenerator : MonoBehaviour
{
    private static int multiplier = 50;
    public static float triangulationThreshold = 20.5f;

    [MenuItem("Boom/Export PLHS")]
    static void ExportPlhs()
    {
        Debug.Log("Exporting Scene to PLHS...");
        CreatePlist();
    }

    private static void CreatePlist()
    {
        // Creating the root object
        var root = new NSDictionary();
        root.Add("Author", "Bogdan Vladu");
        root.Add("PARALLAX_INFO", new NSArray(0));
        var sprites = new NSArray();
        var beziers = new NSArray();
        // Convert all scene game objects to an array of sprites
        GameObject[] allObjects = FindObjectsOfType<GameObject>();
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

        root.Add("SPRITES_INFO", sprites);
        root.Add("LoadedImages", GetLoadedImages());
        root.Add("LHVersion", "1.4.7");
        root.Add("BEZIER_INFO", beziers);
        root.Add("Gravity", new NSArray() {0.0, -10.0});
        root.Add("CreatedWith", "LevelHelper");
        root.Add("JOINTS_INFO", new NSArray());
        root.Add("ScenePreference", GetScenePreferences());
        // Save the property list
        string sceneName = SceneManager.GetActiveScene().name;
        Directory.CreateDirectory("./Levels");
        PropertyListParser.SaveAsXml(root, new FileInfo("Levels/" + sceneName + ".plhs"));
    }

    private static NSDictionary BezierToNSDictionary(GameObject gameObject)
    {
        var bezier = new NSDictionary();
        var spriteShapeController = gameObject.GetComponent<SpriteShapeController>();
        
        if (gameObject.name.Substring(0,7) == "EgyptBG"){
            bezier.Add("TagName", "LHTAG_STONE_GROUND");
            bezier.Add("IsSenzor", false);
            bezier.Add("Tag", 24);
            bezier.Add("Friction", 1.0);
            bezier.Add("Image", "EgyptGroundBG.png");
            bezier.Add("PhysicType", 3);
        }
        else if (gameObject.name.Substring(0,11) == "EgyptGround"){
            bezier.Add("TagName", "LHTAG_STONE_GROUND");
            bezier.Add("IsSenzor", false);
            bezier.Add("Tag", 24);
            bezier.Add("Friction", 1.0);
            bezier.Add("Image", "EgyptGround.png");
            bezier.Add("PhysicType", 0);
        }
        else if (gameObject.name.Substring(0,12) == "JungleGround"){
            bezier.Add("TagName", "LHTAG_STONE_GROUND");
            bezier.Add("IsSenzor", false);
            bezier.Add("Tag", 24);
            bezier.Add("Friction", 1.0);
            bezier.Add("Image", "JungleGround.png");
            bezier.Add("PhysicType", 0);
        }
       else if (gameObject.name.Substring(0,5) != "Water"){
            bezier.Add("TagName", "LHTAG_STONE_GROUND");
            bezier.Add("IsSenzor", false);
            bezier.Add("Tag", 24);
            bezier.Add("Friction", 1.0);
            bezier.Add("Image", spriteShapeController.spriteShape.fillTexture.name + ".png");
            bezier.Add("PhysicType", 0);

        }
        else
        {
            bezier.Add("TagName", "LHTAG_WATER");
            bezier.Add("IsSenzor", true);
            bezier.Add("Tag", 13);
            bezier.Add("Friction", 0.2);
            bezier.Add("Image", "WaterFill.png");
            bezier.Add("PhysicType", 0);
        }


        bezier.Add("IsSimpleLine", true);
        bezier.Add("Color", new NSArray(4) {1.0, 1.0, 1.0, 1.0});
        bezier.Add("IsTile", true);
        bezier.Add("IsPath", false);
        bezier.Add("Density", 0.2);
        bezier.Add("Mask", 65535);
        bezier.Add("GravityScale", 1.0);
        bezier.Add("Group", 0);
        bezier.Add("IsDrawable", true);

        var spline = spriteShapeController.spline;
        var points = new Vector2[spline.GetPointCount()];
        for (int i = 0; i < spline.GetPointCount(); i++)
        {
            //Vector3 vekkie = gameObject.transform.TransformPoint(spline.GetPosition(i));
            //Debug.Log("X:" + vekkie.x + " Y:" + vekkie.y);
            //Debug.Log("X: " + (gameObject.transform.position.x + spline.GetPosition(i).x) + " Y: " + (gameObject.transform.position.y + spline.GetPosition(i).y));
            var newX = (gameObject.transform.position.x + spline.GetPosition(i).x) * multiplier;
            var newY = -(gameObject.transform.position.y + spline.GetPosition(i).y) * multiplier;
            points[i] = new Vector2(newX, newY);
        }

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
        bezier.Add("ZOrder", (int) gameObject.transform.position.z);
        bezier.Add("Category", 1);
        
        // Add curves for collisions
        var curves = new NSArray();
        for (var i = 1; i < spline.GetPointCount(); i++)
        {
            curves.Add(PointsToCurve(points[i - 1], points[i]));
        }
        // Connect last point with first
        curves.Add(PointsToCurve(points[points.Length - 1], points[0]));
        Debug.Log(triangles.Length);
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
        dict.Add("SafeFrame", new NSArray() {480.0, 320.0});
        dict.Add("ZoomValue", 1.0);
        dict.Add("GameWorld", GetCameraBounds());
        dict.Add("BackgroundColor", new NSArray() {0.631373, 0.921569, 0.976471, 0.0});
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
        SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer>();
        Sprite sprite = sr.sprite;
        //Edit to add gates and water and catch short string errors
        if (sprite.name.Substring(0,3) == "box"){
            genProps.Add("TagName", "DEFAULT");
            genProps.Add("Tag", 0);
            genProps.Add("Opacity", 1.0);
        }
        else if (gameObject.name.Substring(0,4) == "GATE") {
            genProps.Add("TagName", "LHTAG_PICKUP_GATE");
            genProps.Add("Tag", 19);
            genProps.Add("Opacity", 1.0);
        }
        else if (sprite.name.Substring(0,5) == "water") {
            genProps.Add("TagName", "LHTAG_WATER");
            genProps.Add("Tag", 13);
            genProps.Add("Opacity", 0.8);
        }
        else {
            genProps.Add("TagName", "DEFAULT");
            genProps.Add("Tag", 0);
            genProps.Add("Opacity", 1.0);
        }
        genProps.Add("Color", new NSArray(4) {1.0, 1.0, 1.0, 0.0});
        genProps.Add("UV", new NSArray(4) {0.0, 0.0, 0.0, 0.0});


        int angle = (int) Quaternion.Inverse(gameObject.transform.rotation.normalized).eulerAngles.z;
        genProps.Add("SHName", sprite.name);
        genProps.Add("Image", sprite.texture.name + ".png");
        genProps.Add("SHScene", sprite.texture.name + ".pshs");
        genProps.Add("Angle", angle);
        genProps.Add("Size", new NSArray(2) {sprite.rect.width / 2, sprite.rect.height / 2});
        genProps.Add("UniqueName", gameObject.name);
        genProps.Add("Position",
            new NSArray(2)
                {gameObject.transform.position.x * multiplier, -gameObject.transform.position.y * multiplier});
        genProps.Add("IsDrawable", true);
        genProps.Add("IsInParallax", false);
        genProps.Add("Scale", new NSArray(2) {gameObject.transform.localScale.x, gameObject.transform.localScale.y});
        genProps.Add("ZOrder", (int) gameObject.transform.position.z);
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
            if (sprite.name.Length < 5 || sprite.name.Substring(0,5) != "water"){ //fudge cos error on 'box'
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

        dict.Add("GeneralProperties", genProps);
        return dict;
    }

    private static NSArray GetLoadedImages()
    {
        var arr = new NSArray();
        for (int i = 0; i < 19; i++)
        {
            var dict = new NSDictionary {{"OrderZ", 0}};
            arr.Add(dict);
        }

        ((NSDictionary) arr[0]).Add("Image", "CityGround.png");
        ((NSDictionary) arr[1]).Add("Image", "CityGroundBG.png");
        ((NSDictionary) arr[2]).Add("Image", "DesertGround.png");
        ((NSDictionary) arr[3]).Add("Image", "EgyptGround.png");
        ((NSDictionary) arr[4]).Add("Image", "EgyptGroundBG.png");
        ((NSDictionary) arr[5]).Add("Image", "FactoryGround.png");
        ((NSDictionary) arr[6]).Add("Image", "FactoryGroundBG.png");
        ((NSDictionary) arr[7]).Add("Image", "FrozenBG.png");
        ((NSDictionary) arr[8]).Add("Image", "GameObjectsBG.png");
        ((NSDictionary) arr[9]).Add("Image", "JungleBGround.png");
        ((NSDictionary) arr[10]).Add("Image", "JungleGround.png");
        ((NSDictionary) arr[11]).Add("Image", "QuicksandFill.png");
        ((NSDictionary) arr[12]).Add("Image", "StonesIce.png");
        ((NSDictionary) arr[13]).Add("Image", "TestGround.png");
        ((NSDictionary) arr[14]).Add("Image", "WaterFill.png");
        ((NSDictionary) arr[15]).Add("Image", "WheelBit.png");
        ((NSDictionary) arr[16]).Add("Image", "Tracks.png");
        ((NSDictionary) arr[16])["OrderZ"] = (NSNumber) 1;
        ((NSDictionary) arr[17]).Add("Image", "GameObjects.png");
        ((NSDictionary) arr[17])["OrderZ"] = (NSNumber) 2;
        ((NSDictionary) arr[18]).Add("Image", "GameObjectsFG.png");
        ((NSDictionary) arr[18])["OrderZ"] = (NSNumber) 6;

        return arr;
    }
}
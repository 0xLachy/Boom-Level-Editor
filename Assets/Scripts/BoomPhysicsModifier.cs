using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Claunia.PropertyList;
public class BoomPhysicsModifier : MonoBehaviour
{
    private static int multiplier = 50;
    //This actually does nothing but I like the reminder of how to add them
    [Tooltip("add _trigger (start when pressed) or leave blank for auto, add _to for second one ALWAYS")]
    public bool isMovingPlatform = false;

    [Header("Movement")]
    //TODO: find out what they actually are, I don't think I named them right
    [Tooltip("default is 5")]
    public float horizontalSpeed = 0.000000f;
    public float verticalSpeed = 0.000000f;

    [Header("Rotation")]
    //slider (range) isn't needed but I like the look :P
    [Tooltip("AngularVelocity used in DRAFT values added to physprops dict")]
    [Range(-50.0f, 50.0f)]
    public float rotationSpeed = 0f;
    public bool lockRotation = false;

    [Header("Gravity")]
    [Tooltip("default is 1.000000f")]
    public float gravity = 1.000000f;

    [Header("DRFT Values")]
    //I could have rotation in here and it will get rid of some confusion, but I like rotation being seperate
    [Tooltip("by default, dens-rest--angVel-fric-type values at zero will use default boom config")]
    public bool use0DRAFT = false;

    public float density;

    [Tooltip("How much the object absorbs the players hit, bounce")]
    public float restitution;

    public float friction;

    [Tooltip("0==default, 1==static, 2==dynamic, 3==non-interactable, 4==onehit")]
    public int type;


    [Header("Other/Debug")]
    public bool customShapeFixtures = false;
    [Tooltip("bomb and ball will default to circle, unless 0DRAFT is true")]
    public bool isCircle = false;
    public float linearDampening = 0.000000f;
    public float group = 0;
    public float category = 1;
    [Tooltip("65534.5==PlayerBlocked, 65539==Balls Blocked")]
    public float mask = 65535;
    public bool ShapePositionOffsett = true;
    public bool ShapeBorder = true;
    public bool canSleep = true;
    public bool isSensor = false;
    //public float DRFTvalue { get { return density + restitution + friction + type; } }

    public NSDictionary CreateCustomFixtures(NSDictionary physProps)
    {
        //public static void moving_flat_xl(NSDictionary physProps)
        //{
        //    physProps.Add("ShapeFixtures", new NSArray(1) {
        //new NSArray(4) {
        //    new NSArray(2) {-59.959999,7.4550171},
        //    new NSArray(2) {-59.959999,-7.4500122},
        //    new NSArray(2) {59.949997,-7.4500122},
        //    new NSArray(2) {59.949997,7.4550171}
        //}
        //});
        //}
        var polygonPaths = gameObject.GetComponent<PolygonCollider2D>();
        physProps.Add("ShapeFixtures", new NSArray(polygonPaths.pathCount));
        for(int i = 0; i < polygonPaths.pathCount; i++)
        {
            Vector2[] polygonPointsArray = polygonPaths.GetPath(i);
            NSArray shapeFixtures = (NSArray)physProps["ShapeFixtures"];
            shapeFixtures.Add(new NSArray(polygonPointsArray.Length));
            //shapeFixtures[i] = new NSArray(polygonPointsArray.Length);
            NSArray nestedShapeFixturesArr = (NSArray)shapeFixtures[i];
            for (int i1 = 0; i1 < polygonPointsArray.Length; i1++)
            {
                Vector2 point = polygonPointsArray[i1]; 
                nestedShapeFixturesArr.Add(new NSArray(2) { point.x * multiplier, point.y * multiplier});
                //nestedShapeFixturesArr[i1] = new NSArray(2) { point.x, point.y };               
            }
        }
        return physProps;
    }
   
}

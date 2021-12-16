using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomPhysicsModifier : MonoBehaviour
{
    //TODO: get better header name than isThings
    [Header("isThings")]
    public bool isHexagon = false;
    public bool isCog = false;
    [Tooltip("This only changes DRFT values, it still kills player on false (The Tag/id is what changes that)")]
    public bool isGoldenNail = false;
    public bool isGreyNail = false;
    [Tooltip("add _trigger (start when pressed) or leave blank for auto, add _to for second one ALWAYS")]
    public bool isMovingPlatform = false;

    [Header("Movement")]
    //TODO: find out what they actually are, I don't think I named them right
    [Tooltip("default is 5")]
    public float horizontalSpeed = 0.000000f;
    public float verticalSpeed = 0.000000f;

    [Header("Rotation")]
    //slider (range) isn't needed but I like the look :P
    [Tooltip("default for hexagon and cog 4")]
    [Range(-50.0f, 50.0f)]
    public float rotationSpeed = 0f;
    public bool lockRotation = false;

    [Header("Gravity")]
    [Tooltip("default is 1.000000f")]
    public float gravity = 1.000000f;

    [Header("DRFT")]
    [Tooltip("by default, dens-rest-fric-type values at zero will use default boom config")]
    public bool use0DRFT = false;

    public float density;

    [Tooltip("How much the object absorbs the players hit, bounce")]
    public float restitution;

    public float friction;

    [Tooltip("0==default, 1==static, 2==dynamic, 3==non-interactable, 4==onehit")]
    public int type;

    
    //public float DRFTvalue { get { return density + restitution + friction + type; } }
   
}

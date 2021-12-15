using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomPhysicsModifier : MonoBehaviour
{
    public bool isMovingPlatform = false;
    //default vert is 5.0f
    public float verticalSpeed = 0.000000f;
    public float horizontalSpeed = 0.000000f;

    public bool isSpike = false;
    //True makes object static
    public bool lockRotation = false;
    //I put this so I would have a slider, feel free to change or remove
    [Tooltip("default for hexagon and others is 5")]
    [Range(-50.0f, 50.0f)]
    public float rotationSpeed = 0f;
    //default is 1.000000
    public float gravity = 1.000000f;
    //not sure if this is needed, default set to false for past rotation objects
    public bool isHexagon = false;
    public bool isRotateCog = false;


    public bool wantZeroDFTR = false;
    //public bool customDensity = false;
    public float density;

    [Tooltip("How much the object absorbs the players hit")]
    public float restitution;

    //public bool customFriction = false;
    public float friction;

    //type one static, type 2 seems to fall, thats all I know.
    //public bool customType = false;
    [Tooltip("0==default, 1==static, 2==dynamic, 3==non-interactable, 4==onehit")]
    public int type;

    private void Start()
    {
        Debug.Log(density);
    }
}

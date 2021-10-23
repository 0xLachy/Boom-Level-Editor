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
    [Range(-50.0f, 50.0f)]
    public float rotationSpeed = 5f;
    //default is 1.000000
    public float gravity = 1.000000f;
    //not sure if this is needed, default set to false for past rotation objects
    public bool isHexagon = false;
}

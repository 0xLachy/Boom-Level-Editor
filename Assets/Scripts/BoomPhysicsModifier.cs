using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomPhysicsModifier : MonoBehaviour
{
    public bool rotatingObject = true;
    public bool isSpike = false;
    //True makes object static
    public bool lockRotation = false;
    //I put this so I would have a slider, feel free to change or remove
    [Range(0.0f, 50.0f)]
    public float rotationSpeed = 5f;

    //not sure if this is needed, default set to false for past rotation objects
    public bool isHexagon = false;
}

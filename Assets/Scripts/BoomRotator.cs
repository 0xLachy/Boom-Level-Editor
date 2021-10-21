using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomRotator : MonoBehaviour
{
    //This may not work if you disable rotation and could even make the object disappear
    public bool lockRotation = false;
    public float rotationSpeed = 5f;

    //not sure if this is needed, default set to false for past rotation objects
    public bool handledBySH = false;
}

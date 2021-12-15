using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Claunia.PropertyList;


public class CogFixer : MonoBehaviour
{
    public static void AddCogPhysics(NSDictionary physProps, BoomPhysicsModifier BPM)
    {
        physProps.Add("ShapePositionOffset", new NSArray(2) { 0.000000, 0.000000 });
        physProps.Add("AngularDamping", 0.000000);
        physProps.Add("Density", 0.200000);
        physProps.Add("Mask", 65535);
        physProps.Add("IsCircle", false);
        //physProps.Add("FixedRot", rotationComponent.lockRotation);
        //physProps.Add("GravityScale", 1.000000);
        physProps.Add("Type", 1);
        physProps.Add("HandledBySH", false);
        physProps.Add("IsBullet", false);
        physProps.Add("Group", 0);
        physProps.Add("CanSleep", true);
        //physProps.Add("LinearVelocity", new NSArray(2) { 0.000000, 0.000000 });
        physProps.Add("ShapeFixtures", new NSArray(8) {
            new NSArray(4) {
            new NSArray(2) { 50.420013, 11.434998 },
            new NSArray(2) { 71.369995, 28.410000 },
            new NSArray(2) { 61.825012, 45.160000 },
            new NSArray(2) { 35.000000, 38.000000 },
            },
            new NSArray(4) {
            new NSArray(2) { 60.174988, -47.120003 },
            new NSArray(2) { 70.565002, -30.974998 },
            new NSArray(2) { 50.420013, -10.620003 },
            new NSArray(2) { 34.940002, -37.790001 },
            },

            new NSArray(4) {
            new NSArray(2) { -62.300003, -44.800003 },
            new NSArray(2) { -34.860001, -37.324997 },
            new NSArray(2) { -50.425003, -10.870003 },
            new NSArray(2) { -70.779999, -28.470001 },
            },
                    
            new NSArray(4) {
            new NSArray(2) { -50.425003, 11.470001 },
            new NSArray(2) { -34.865005, 38.375000 },
            new NSArray(2) { -60.949997, 47.279999 },
            new NSArray(2) { -70.490005, 30.950001 },
            },

            new NSArray(8) {
            new NSArray(2) { 50.420003, -10.870003 },
            new NSArray(2) { -34.860001, -37.324997 },
            new NSArray(2) { -15.985001, -48.349998 },
            new NSArray(2) { 15.010010, -48.394997 },
            new NSArray(2) { 15.600006, 48.974998 },
            new NSArray(2) { -15.994995, 48.764999 },
            new NSArray(2) { -34.865005, 38.375000 },
            new NSArray(2) { -50.425003, 11.470001 }
            },

            new NSArray(4) {
            new NSArray(2) { -11.320007, -75.705002 },
            new NSArray(2) { 8.399994, -75.705002 },
            new NSArray(2) { 15.010010, -48.394997 },
            new NSArray(2) { -15.985001, -48.349998 },
                },

            new NSArray(6) {
            new NSArray(2) { 34.940002, -37.790001 },
            new NSArray(2) { 50.420013, -10.620003 },
            new NSArray(2) { 50.420013, 11.434998 },
            new NSArray(2) { 35.000000, 38.000000 },
            new NSArray(2) { 15.600006, 48.974998 },
            new NSArray(2) { 15.010010, -48.394997 } },

            new NSArray(3) {
            new NSArray(2) { -15.994995, 48.764999 },
            new NSArray(2) { 15.600006, 48.974998 },
            new NSArray(2) { 9.875000, 76.120003 },
            new NSArray(2) { -7.934998, 76.120003}
            }
            });
        //var vector2Points = new NSArray()
        physProps.Add("Category", 1);
        physProps.Add("Friction", 1.000000);
        physProps.Add("Restitution", 0.200000);
        physProps.Add("IsSensor", false);
        physProps.Add("AngularVelocity", BPM.rotationSpeed);
        physProps.Add("LinearDamping", 0.000000);
        physProps.Add("ShapeBorder", new NSArray(2) { 0.000000, 0.000000 });
    }
}

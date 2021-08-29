using UnityEngine;

public class BoomAnimation : MonoBehaviour
{
    public string AnimName;
    public double AnimSpeed;
    public int AnimRepetitions = 1;
    public bool AnimAtStart = true;
    public bool AnimLoop = true;

    // public BoomAnimation(double animSpeed, string animName) =>
    //     (AnimSpeed, AnimName) = (animSpeed, animName);
    //
    // public BoomAnimation(double animSpeed, string animName, int animRepetitions, bool animAtStart,
    //     bool animLoop) =>
    //     (AnimSpeed, AnimName, AnimRepetitions, AnimAtStart, AnimLoop) =
    //     (animSpeed, animName, animRepetitions, animAtStart, animLoop);
}

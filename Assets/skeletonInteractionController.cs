using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skeletonInteractionController : MonoBehaviour
{
    string anim;
    public void playAnimation(string animation)
    {
        anim = animation;
        Invoke("play", 3.5f);
    }
    void play()
    {

        this.GetComponent<Animator>().Play(anim);
    }
}

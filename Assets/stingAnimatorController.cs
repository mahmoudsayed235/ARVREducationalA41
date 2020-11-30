using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stingAnimatorController : MonoBehaviour
{
    public Animator sting;
    public bool Forward;
    public bool Backward;
    public bool Left;
    public bool Right;
    public bool Defend;
    public bool Idle;
    private void OnEnable()
    {
        if (Forward)
        {
            sting.SetBool("Idle", false);
            sting.SetBool("Fly Backward", false);
            sting.SetBool("Fly Left", false);
            sting.SetBool("Fly Right", false);
            sting.SetBool("Defend", false);
            sting.SetBool("Fly Forward", true);
        }
        else if (Backward)
        {
            sting.SetBool("Idle", false);
            sting.SetBool("Fly Forward", false);
            sting.SetBool("Fly Left", false);
            sting.SetBool("Fly Right", false);
            sting.SetBool("Defend", false);
            sting.SetBool("Fly Backward", true);
        }
        else if (Left)
        {
            sting.SetBool("Idle", false);
            sting.SetBool("Fly Forward", false);
            sting.SetBool("Fly Backward", false);
            sting.SetBool("Fly Right", false);
            sting.SetBool("Defend", false);
            sting.SetBool("Fly Left", true);
        }
        else if (Right)
        {
            sting.SetBool("Idle", false);
            sting.SetBool("Fly Forward", false);
            sting.SetBool("Fly Backward", false);
            sting.SetBool("Fly Left", false);
            sting.SetBool("Defend", false);
            sting.SetBool("Fly Right", true);
        }
        else if (Defend)
        {
            sting.SetBool("Idle", false);
            sting.SetBool("Fly Forward", false);
            sting.SetBool("Fly Backward", false);
            sting.SetBool("Fly Left", false);
            sting.SetBool("Fly Right", false);
            sting.SetBool("Defend", true);
        }
        else if (Idle)
        {
            sting.SetBool("Fly Forward", false);
            sting.SetBool("Fly Backward", false);
            sting.SetBool("Fly Left", false);
            sting.SetBool("Fly Right", false);
            sting.SetBool("Defend", false);
            sting.SetBool("Idle", true);
        }

    }
}

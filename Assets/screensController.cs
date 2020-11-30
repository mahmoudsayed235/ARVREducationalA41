using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screensController : MonoBehaviour
{
    public Animator screensAnimator;
    
  
    private void OnEnable()
    {
        /*
        int start = PlayerPrefs.GetInt("ScreensStart");
        if (start==0)
        {
            PlayerPrefs.SetInt("ScreensStart", 1);
            
            screensAnimator.SetTrigger("start");
        }
        else if (start == 1)
        {
             PlayerPrefs.SetInt("ScreensStart", 0);
            screensAnimator.SetTrigger("back");

        }*/

        screensAnimator.SetTrigger("start");
    }
}

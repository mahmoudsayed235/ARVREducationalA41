using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenCapturer : MonoBehaviour
{
    public string namePrefix;
    public int counter = 0;

	void Update ()
    {
        if(Input.GetKeyUp(KeyCode.C))
        {
            ScreenCapture.CaptureScreenshot(string.Format("{0}_{1}.png", namePrefix, counter++));
        }
	}
}

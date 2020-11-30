using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;


public class MySettings : MonoBehaviour
{
    void Start()
    {
        XRSettings.eyeTextureResolutionScale = 1.7f;// tune this value between 1.4-2.0
        OVRManager.tiledMultiResLevel = OVRManager.TiledMultiResLevel.LMSHigh;
        OVRManager.display.displayFrequency = 72.0f;

        //  QualitySettings.antiAliasing = 8;
        //        XRSettings.eyeTextureResolutionScale = 1.8f;
        //OVRManager.tiledMultiResLevel = OVRManager.TiledMultiResLevel.LMSHigh;
        // OVRManager.display.displayFrequency = 72.0f;

    }
}

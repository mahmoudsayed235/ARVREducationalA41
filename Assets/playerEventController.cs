using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerEventController : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnEnable()
    {
        GameObject eventController = GameObject.FindGameObjectWithTag("Center");
        eventController.GetComponent<playerEvents>().setAnchors();
        GameObject reticuleController = GameObject.FindGameObjectWithTag("Center");
        reticuleController.GetComponent<reticule>().setCamera();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

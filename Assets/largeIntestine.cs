using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class largeIntestine : MonoBehaviour
{
    Material defaultMaterial;
    // Start is called before the first frame update
    public void setDefaultMaterial(Material def)
    {
        defaultMaterial = def;
        Invoke("setMAterial",8f);


    }
    void setMAterial()
    {
        this.GetComponent<MeshRenderer>().material = defaultMaterial;
    }
    }

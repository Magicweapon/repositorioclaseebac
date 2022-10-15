using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public bool bVar1;
    
    // Start is called before the first frame update
    void Start()
    {
        bVar1 = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (bVar1 == true)
        {
            bVar1 = false;
            GetComponent<MeshRenderer>().material.color = Color.black;
        }
        else
        {
            bVar1 = true;
            GetComponent<MeshRenderer>().material.color = Color.white;
        }
    }
}

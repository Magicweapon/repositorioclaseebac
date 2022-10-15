using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleScript : MonoBehaviour
{
    public bool bVar1;
    public GameObject Sphere1;
    public GameObject Sphere2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Sphere1.GetComponent<MeshRenderer>().material.color == Color.white && Sphere2.GetComponent<MeshRenderer>().material.color == Color.white)
        {
            bVar1 = true;
            GetComponent<MeshRenderer>().material.color = Color.white;
        }
        else
        {
            bVar1 = false;
            GetComponent<MeshRenderer>().material.color = Color.black;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrScript : MonoBehaviour
{
    public bool bVar1;
    public GameObject Cube;
    public GameObject Cylinder;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Cube.GetComponent<MeshRenderer>().material.color == Color.white || Cylinder.GetComponent<MeshRenderer>().material.color == Color.white)
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

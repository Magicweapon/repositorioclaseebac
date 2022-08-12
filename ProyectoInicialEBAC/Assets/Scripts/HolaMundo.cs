using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    int x;
    
    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        
        Debug.Log("Hola Mundo");
        Debug.LogError("Algo salio muy mal");
        Debug.LogWarning("Algo paso");
    }

    // Update is called once per frame
    void Update()
    {
        x = x + 1;
        Debug.Log(x);
    }
}

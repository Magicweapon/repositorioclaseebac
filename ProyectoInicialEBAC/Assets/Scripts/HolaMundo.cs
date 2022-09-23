using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    int x;

    private void Awake()
    {
        Debug.Log("Hola desde Awake");
    }

    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        
        Debug.Log("Hola Mundo desde Start");
        //Debug.LogError("Algo salio muy mal");
        //Debug.LogWarning("Algo paso");
    }

    // Update is called once per frame
    void Update()
    {
        //x = x + 1;
        //Debug.Log(x);

        Debug.Log("Hola desde Update");
    }
    private void FixedUpdate()
    {
        Debug.LogWarning("Hola desde Fixed Update cada 50 frames");
    }
    private void LateUpdate()
    {
        Debug.Log("Hola desde Late Update");
    }
    private void OnEnable()
    {
        Debug.LogWarning("El objeto ha sido habilitado");
    }
    private void OnDisable()
    {
        Debug.LogWarning("El objeto ha sido inhabilitado");
    }
}

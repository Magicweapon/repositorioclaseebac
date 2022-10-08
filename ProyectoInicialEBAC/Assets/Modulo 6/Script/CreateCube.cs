using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCube : MonoBehaviour
{
    public GameObject PrefabCube;

    private void Awake()
    {
        Instantiate<GameObject>(PrefabCube);
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate<GameObject>(PrefabCube);
    }

    private void OnEnable()
    {
        var cube = Instantiate(PrefabCube);
        cube.transform.position = new Vector3(1.0f, 5.0f, 1.0f);
    }

    private void OnDisable()
    {
        var cube = Instantiate(PrefabCube);
        cube.transform.position = new Vector3(1.0f, 5.0f, 1.0f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject PrefabCube;
    public List<GameObject> cubesList;
    public float scaleFactor;
    public int cubeNumb = 0;

    // Start is called before the first frame update
    void Start()
    {
        cubesList = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        cubeNumb++;

        GameObject tempGameObject = Instantiate(PrefabCube);
        tempGameObject.name = "Cube number " + cubeNumb;

        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
        tempGameObject.transform.position = Random.insideUnitSphere;

        cubesList.Add(tempGameObject);

        List<GameObject> objectsToDelete = new List<GameObject>();

        foreach(GameObject cube in cubesList)
        {
            float scale = cube.transform.localScale.x;
            scale *= scaleFactor;

            cube.transform.localScale = Vector3.one * scale;

            if (scale <= 0.1)
            {
                objectsToDelete.Add(cube);
            }
        }

        foreach(GameObject cube in objectsToDelete)
        {
            cubesList.Remove(cube);
            Destroy(cube);
        }
    }
}

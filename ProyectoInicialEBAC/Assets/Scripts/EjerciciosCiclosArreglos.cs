using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosCiclosArreglos : MonoBehaviour
{
    int[] myIntArray1 = new int[3];
    int[] myIntArray2 = new int[3];
    int[] myIntArray3 = new int[3];

    string[] myStringArray = new string[6] { "El", "perro", "juega", "a", "la", "pelota" };

    int[,] myMatrice = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
    int[] myVector = new int[3] { 7, 8, 9 };
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            myIntArray1[i] = Random.Range(0, 15);
            myIntArray2[i] = Random.Range(0, 15);

            myIntArray3[i] = myIntArray1[i] + myIntArray2[i];
        }
        
        string mySentence = "";

        foreach (string word in myStringArray)
        {
            if (word == myStringArray[5])
            {
                mySentence = mySentence + word;
            }
            else
            {
                mySentence = mySentence + word + " ";
            }
        }

        Debug.Log(mySentence);

        int[] myResult = new int[2];

        //myResult[0] = myMatrice[0, 0] * myVector[0] + myMatrice[0, 1] * myVector[1] + myMatrice[0, 2] * myVector[2];
        //myResult[1] = myMatrice[1, 0] * myVector[0] + myMatrice[1, 1] * myVector[1] + myMatrice[1, 2] * myVector[2];

        for (int i = 0; i < myResult.Length; i++)
        {
            myResult[i] = myMatrice[i, 0] * myVector[0] + myMatrice[i, 1] * myVector[1] + myMatrice[i, 2] * myVector[2];
        }

        Debug.Log(myResult[0]);
        Debug.Log(myResult[1]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

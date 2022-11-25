using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
    int integerNumber = 0;
    float floatNumber = 1.0f;

    float fVar1 = 5.0f;
    float fVar2 = 1.2f;
    int iVar1 = 0;
    int iVar2;

    public string word;

    float fVar3 = 5.4567f;
    string fullName = "Cesar Baldo Gutierrez";

    string sVar1 = "1234";
    string sVar2 = "5678";
    string sentence = "Ejercicio para el módulo 8 del curso de Unity";
    string sVar3 = "El perro jugó con la pelota";

    int iVar5 = 0;

    // Start is called before the first frame update
    void Start()
    {
        float tempVar = fVar1 * fVar2;
        iVar1 = (int)tempVar;

        //iVar2 = Random.Range(0, 10);
        //string result = (iVar2 % 2 == 0) ? iVar2.ToString() + "Es par" : iVar2.ToString() + "Es impar";

        Debug.Log(iVar1);

        Color colour;
        switch (word)
        {
            case "Pelota":
                colour = Color.yellow;
                break;
            case "Perro":
                colour = Color.cyan;
                break;
            default:
                colour = Color.magenta;
                break;
        }

        GetComponent<MeshRenderer>().material.color = colour;

        string decimals = fVar3.ToString();

        Debug.Log(decimals);

        string firstName = fullName.Substring(0, 5);
        string secondName = fullName.Substring(6, 5);
        string lastName = fullName.Substring(12);

        Debug.Log(firstName);
        Debug.Log(secondName);
        Debug.Log(lastName);

        string[] names = fullName.Split(' ');

        foreach (var name in names)
        {
            Debug.Log(name);
        }

        int iVar3, iVar4;

        if (int.TryParse(sVar1, out iVar3) && int.TryParse(sVar2, out iVar4))
        {
            int result = iVar3 + iVar4;
            Debug.Log(result);
        }

        //var i = 0;
        //for (i = 0; i < sentence.Length; i += 2)
        //{
        //    Debug.Log(sentence[i]);
        //}

        string newString = sVar3.Substring(5);
        Debug.Log(newString);

    }

    // Update is called once per frame
    void Update()
    {
        integerNumber += 2;

        if (iVar5 % 2 == 0 && iVar5 < sentence.Length)
        {
            Debug.Log(sentence[iVar5]);
        }
        iVar5++;

    }

    private void FixedUpdate()
    {
        iVar2 = Random.Range(0, 10);
        Color colour = (iVar2 % 2 == 0) ? Color.red : Color.green;
        // Rojo es par y verde es non

        GetComponent<MeshRenderer>().material.color = colour; 

        floatNumber *= 1.2f;
    }
}

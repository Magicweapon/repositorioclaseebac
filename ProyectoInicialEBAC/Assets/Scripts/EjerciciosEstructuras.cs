using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosEstructuras : MonoBehaviour
{
    List<string> stringList = new List<string>();
    
    // Start is called before the first frame update
    void Start()
    {
        stringList.Add("Perro");
        stringList.Add("Gato");
        stringList.Add("Iguana");
        stringList.Add("Cangrejo");
        stringList.Add("Vaca");
        stringList.Add("Perro");
        stringList.Add("Cangrejo");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public List<int> firstFunction(int size, int min, int max)
    {
        var intList = new List<int>();

        for (int i = 0; i < size; i++)
        {
            intList.Add(Random.Range(min, max));
        }

        return intList;
    }

    public int[] secondFunction(int[] array)
    {
        var intList = new List<int>();

        foreach (var integer in array)
        {
            intList.Add(integer);
        }

        //intList = intList.OrderByDescendent(p => p).ToList();
        var newArray = intList.ToArray();

        return newArray;
    }

    public HashSet<string> thirdFunction(List<string> list)
    {
        //var stringList = list.Distinct<string>().ToList();
        var hashSet = new HashSet<string>();
        
        foreach (var word in stringList)
        {
            hashSet.Add(word);
        }

        return hashSet;
    }

    public void fourthFunction(Stack<string> stack)
    {
        var queue = new Queue<string>();

        foreach (var element in stack)
        {
            Debug.Log(element);
            queue.Enqueue(element);
            Debug.Log(queue.Peek());
        }
    }
}
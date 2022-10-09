using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Instantcer : ScriptableObject
{
    public GameObject prefab;
    public GameObject dotprefab;
    private int numb;
    public void CreateInstance()
    {
        Instantiate(prefab);
        Instantiate(dotprefab);
    }

    public void CreateInstance(Vector3Data obj)
    {
        Instantiate(prefab, obj.value, Quaternion.identity);
    }

    public void CreateInstanceFromList(Vector3Lists obj)
    {
        foreach (var t in obj.Vector3List)
        {
            Instantiate(prefab, t.value, Quaternion.identity);
        }
    }

    public void CreateInstanceFromListCounting(Vector3Lists obj)
    {
        Instantiate(prefab, obj.Vector3List[numb].value, Quaternion.identity);
        numb++;
        if (numb == obj.Vector3List.Count)
        {
            numb = 0;
        }

    }
    
    public void CreateInstanceListRandomly(Vector3Lists obj)
    {
        numb = Random.Range(0, obj.Vector3List.Count - 1);
        Instantiate(prefab, obj.Vector3List[numb].value, Quaternion.identity);
       

    }

    
}



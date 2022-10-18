using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Instantcer : ScriptableObject
{
    public GameObject redprefab;
    public GameObject greenprefab;
    public GameObject yelloPrefab;
    public GameObject rottenPrefab;
    public GameObject Bombprefab;
    private int numb;
    public void CreateInstance()
    {
        Instantiate(redprefab);
        Instantiate(greenprefab);
        Instantiate(yelloPrefab);
        Instantiate(rottenPrefab);
        Instantiate(Bombprefab);
    }

    public void CreateInstance(Vector3Data obj)
    {
        Instantiate(redprefab,greenprefab, yelloPrefab, rottenPrefab, Bombprefab, obj.value, Quaternion.identity);
    }

    private void Instantiate(GameObject original, GameObject position, GameObject instantiateInWorldSpace, GameObject parent, GameObject bombprefab, Vector3 objValue, Quaternion identity)
    {
        throw new System.NotImplementedException();
    }

    public void CreateInstanceFromList(Vector3Lists obj)
    {
        foreach (var t in obj.Vector3List)
        {
            Instantiate(redprefab,greenprefab, yelloPrefab, rottenPrefab, Bombprefab, t.value, Quaternion.identity);
        }
    }

    public void CreateInstanceFromListCounting(Vector3Lists obj)
    {
        Instantiate(redprefab, greenprefab, yelloPrefab, rottenPrefab, Bombprefab, obj.Vector3List[numb].value, Quaternion.identity);
        numb++;
        if (numb == obj.Vector3List.Count)
        {
            numb = 0;
        }

    }
    
    public void CreateInstanceListRandomly(Vector3Lists obj)
    {
        numb = Random.Range(0, obj.Vector3List.Count - 4);
        Instantiate(redprefab, greenprefab, yelloPrefab, rottenPrefab, Bombprefab, obj.Vector3List[numb].value, Quaternion.identity);
       

    }

    
}



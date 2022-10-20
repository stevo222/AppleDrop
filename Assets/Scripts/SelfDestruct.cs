using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    public float seconds = 1;
    private WaitForSeconds WfSObj;
    
    
    private IEnumerator Start()
    {
        WfSObj = new WaitForSeconds(seconds);
        yield return WfSObj;
        //Destroy(gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hit:" + other.transform.name);

        if (tag == "Object")
        {
            Destroy(gameObject);
        }
    }
    
}

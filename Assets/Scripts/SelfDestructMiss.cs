using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestructMiss : MonoBehaviour
{
    public float seconds = 6;
    private WaitForSeconds WfSObj;
    
    
    private IEnumerator Start()
    {
        WfSObj = new WaitForSeconds(seconds);
        yield return WfSObj;
        Destroy(gameObject);
    }
}

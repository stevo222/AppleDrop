using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    public float seconds = 1;
    private WaitForSeconds WfSObj;
    public bool bomb = false;
    public GameObject explosion;
    
    
    private IEnumerator Start()
    {
        WfSObj = new WaitForSeconds(seconds);
        yield return WfSObj;
        //Destroy(gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hit:" + other.transform.name);

        if (other.CompareTag("Basket"))
        {
            if (bomb)
            {
                Instantiate(explosion, transform.position + (Vector3.forward * -3), Quaternion.identity);
                other.transform.parent.gameObject.SetActive(false);
            }
            Destroy(gameObject);
        }
    }
    
}

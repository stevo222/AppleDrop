using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Down : MonoBehaviour
{
    private float _speed = 3.5f;
    void Start()
    {
      
    }

   // private void FixedUpdate()
   // {
      //  transform.Translate(Vector3.down * _speed * Time.deltaTime);

   // }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hit:" + other.transform.name);

        if (other.tag == "object")
        {
            Destroy(other.gameObject);
        }
    }
}

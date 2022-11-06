
using System;
using UnityEngine;

public class scorepoints : MonoBehaviour
{

    
    public float speed = 4.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
      transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

   

    
}



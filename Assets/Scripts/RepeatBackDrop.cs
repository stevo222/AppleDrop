using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackDrop : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWidth;

    private float speed = 8;

    private float rightBound = -5;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
        transform.Translate(Vector3.right * (Time.deltaTime * speed));
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < startPos.x - repeatWidth)
        {
            transform.position = startPos;
           
        }
    }
}

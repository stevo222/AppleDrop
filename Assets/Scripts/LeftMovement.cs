using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftMovement : MonoBehaviour
{
    private float speed = 10;

    private float leftBound = -5;

    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }

    // Update is called once per frame
}

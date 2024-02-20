using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sw  : MonoBehaviour
{
    public float speedx = 0.8f;
    public float rangex = 3;

    float startX;
    int dirX = 1;

    // Start is called before the first frame update
    void Start()
    {
        startX = transform.position.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector3.right * speedx * Time.deltaTime * dirX);
        if (transform.position.x < startX || transform.position.x > startX + rangex)
            dirX *= -1;
    }
}
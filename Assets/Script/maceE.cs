using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maceE : MonoBehaviour
{
    public float speed = 0.8f;
    public float range = 3;

    float strY;
    int dir = 1;
    // Start is called before the first frame update
    void Start()
    {
        strY = transform.position.y;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime * dir);
        if (transform.position.y < strY || transform.position.y > strY + range)
            dir *= -1;
    }
}

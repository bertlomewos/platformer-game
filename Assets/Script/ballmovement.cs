using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballmovement : MonoBehaviour
{
    Ballcontrol bcol;
    float dir = 0;
    public float speed = 200;

    public Rigidbody2D rb;
    private void Awake()
    {
        bcol = new Ballcontrol();
        bcol.Enable();

        bcol.Land.Move.performed += ctx =>
        {
            dir = ctx.ReadValue<float>();
        };
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(dir * speed * Time.fixedDeltaTime, rb.velocity.y);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class checkpoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag == "Player")
        {
            ballmanager.lastcheckpointpos = transform.position;
            GetComponent<SpriteRenderer>().color = Color.red;
        }
    }
}

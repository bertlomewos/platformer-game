using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballcollison : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Enemy")
        {
            ballmanager.isgameover = true;
            gameObject.SetActive(false);
        }
        if (collision.transform.tag == "trap")
        {
            portel.didIwin = true;
            gameObject.SetActive(false);
        }
    }
}

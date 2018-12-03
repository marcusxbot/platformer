using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killenemy : MonoBehaviour {

    public int kill = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
    if(collision.tag == "Player")
        {
            kill++;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        kill--;
    }

}

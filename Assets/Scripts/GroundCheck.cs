using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public int touches;
    
    private void OnTriggerEnter2D(Collider2D collision) // enter the collider
    {
        touches++; //add touches
    }

    private void OnTriggerExit2D(Collider2D collision) // exit the collider
    {
        touches--; // remove touches
    }
}

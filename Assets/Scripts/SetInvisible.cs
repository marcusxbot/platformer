using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetInvisible : MonoBehaviour
{
   
    void Start() //when start
    {
           
        GetComponent<SpriteRenderer>().enabled = false; // Makes invisible
    }
}

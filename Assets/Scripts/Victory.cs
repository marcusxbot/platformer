using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    public string levelToLoad = "nivå1";

    private void OnTriggerEnter2D(Collider2D collision) // if object enter the 2D collider
    {
        if(collision.tag == "Player") // Only if the object have tag Player
        {
            
            print("Yay"); //print letters
            
            SceneManager.LoadScene(levelToLoad); //loads scene
        }
    }
}

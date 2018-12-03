using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HurtObject : MonoBehaviour
{
    
    public string loadfirstscene = "nivå1";

    public void OnColliderEnter2D(Collision2D collision) // if object touch
    {
        if(collision.gameObject.tag == "Player") // if objeckt with tag player touch
        {
            Scene active = SceneManager.GetActiveScene();  // makes scene load
            SceneManager.LoadScene(loadfirstscene);
        }
    }

}

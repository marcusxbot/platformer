using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

    public string RestartGame = "nivå1";
	
	void Update () // Update is called once per frame
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(RestartGame); //loads scene
        }
    }

}

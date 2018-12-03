using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int score = 1;

    private void OnTriggerEnter2D(Collider2D collision) // if object enter the collider
    {
        if (collision.tag == "Player") // if object has tag player
        {
            //Skapa en temporär variabel "controller" och sätt den till
            //resultatet av sökningen efter objektet med taggen "GameController".
            GameObject controller = GameObject.FindWithTag("GameController");
            if (controller != null)
            {
                //Skapa en temporär variabel "tracker" och sätt den till
                //resultatet av sökningen efter komponenten "ScoreTracker".
                ScoreTracker tracker = controller.GetComponent<ScoreTracker>();
                if (tracker != null)
                {
                    tracker.totalScore += score;
                }
                else
                {
                    Debug.LogError("ScoreTracker saknas på GameController."); // print words
                }
            }
            else
            {
                Debug.LogError("GameContoller finns inte."); // print words
            }

            Destroy(gameObject); // destroy self
        }
    }
}

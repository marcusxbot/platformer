using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using TMPro; //<- "namespace"

public class ScoreTracker : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int totalScore;

    private void Update() // Constently activates the code when game is on
    {
        scoreText.text = string.Format("Score: {0}", totalScore); // It shows the totalscore
    }
}

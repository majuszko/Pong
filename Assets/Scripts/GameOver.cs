using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    
    public ScoreS Score;
    
    void Update()
    {
        if (Score.score1 >= Score.goalToWin)
        {
            SceneManager.LoadScene("GameOver");
            

        }
        else if (Score.score2 >= Score.goalToWin)
        {
            SceneManager.LoadScene("GameOver2");
            
        }
    }
}

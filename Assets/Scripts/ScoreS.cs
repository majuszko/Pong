using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreS : MonoBehaviour
{

    public int score1 = 0;
    public int score2 = 0;

    public GameObject scoreText1;
    public GameObject scoreText2;

    public int goalToWin;

    // Update is called once per frame
    void Update()
    {
        if (this.score1 >= this.goalToWin  || this.score2 >= this.goalToWin){
            Debug.Log("Game Won");
        }
        Text ui1 = this.scoreText1.GetComponent<Text>();
        ui1.text = this.score1.ToString();

        Text ui2 = this.scoreText2.GetComponent<Text>();
        ui2.text = this.score2.ToString();
    }

    /*private void FixedUpdate()
    {
        Text ui1 = this.scoreTextPlayer1.GetComponent<Text>();
        ui1.text = this.score1.ToString();

        Text ui2 = this.scoreTextPlayer2.GetComponent<Text>();
        ui2.text = this.score2.ToString();
    }*/

    public void GoalPlayer1()
    {
        this.score1++;
    }

    public void GoalPlayer2()
    {
        this.score2++;
    }
}
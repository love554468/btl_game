using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text Left_score;
    public Text Right_score;
    public Text hhighScore;
    public GameObject[] player;
    public GameObject gameOverPanel;
    public GameObject highScore;

    public void setHighScore(string txt ) {
        if(hhighScore)
        {
            hhighScore.text = txt;
        }
    }
    public void destroyPlayer()
    {
        Destroy (player[1]);
        Destroy (player[0]);
        Debug.Log("Destroyed");
    }

    public void setLeft_score(string score_text)
    {
        if(Left_score)
        {
            Left_score.text = score_text;
        }
    }
    public void setRight_score(string value)
    {
        if(Right_score)
        {
            Right_score.text = value;
        }
    }
    public void showGameOver(bool state_bool)
    {
        if(gameOverPanel)
        {
            gameOverPanel.SetActive(state_bool);
            highScore.SetActive(state_bool);
        }
    }
}

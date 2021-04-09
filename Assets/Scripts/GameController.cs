using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    int scoreLeft = 0;
    int scoreRight = 0;
    int highScore = 0;
    int a = 0;
    bool isGameOver;
    public GameObject[] gameObject;
    Vector2 spawnPosL = new Vector2(3.67f,-1.707317f);
    Vector2 spawnPosR = new Vector2(-3.67f,-1.707317f);
    UIManager ui;
    void Start()
    {
        ui = FindObjectOfType<UIManager>();
        ui.setLeft_score("Score: 0");
        ui.setRight_score("Score: 0");
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameOver == true)
        {
            ui.showGameOver(true);
            Debug.Log("t");
            if(scoreRight==scoreLeft)
            {
                ui.setHighScore("Score Same:"+scoreRight);
                return;
            }
            if(scoreRight>scoreLeft)
            {
                ui.setHighScore("Score Right:"+scoreRight);
            }
            else
            {
                ui.setHighScore("Score Left: "+scoreLeft);
            }
            Debug.Log("t");
        }
    }

//test    
    // public int getHighScore()
    // {
    //     if(scoreRight>scoreLeft)
    //     {
    //         a = -1;
    //         return scoreRight;
    //     }
    //     else
    //     {
    //         return scoreLeft;
    //     }
    // }

    public void set_HighScore(int val)
    {
        highScore = val; 
    }

    public void setScore(int value)
    {
        scoreLeft = value;
    }

    public void setScoreRight(int value)
    {
        scoreRight = value;

    }

    public int GetScore()
    {
        return scoreLeft;
    }

    public int GetScoreRight()
    {
        return scoreRight;
    }

    public void IncreaseScore()
    {
        scoreLeft += 1;
        ui.setLeft_score("Score: "+scoreLeft);
    }

    public void IncreaseScoreRight()
    {
        scoreRight += 1;
        Debug.Log(scoreRight+"hihi");
        ui.setRight_score("Score: "+scoreRight);
    }

    public bool IsGameOver()
    {
        return isGameOver;
    }

    public void SetGameOver(bool state)
    {
        isGameOver = state;
    }
    public void replay()
    {
        isGameOver = false;
        ui.setLeft_score("Score: 0");
        ui.setRight_score("Score: 0");
        ui.showGameOver(false);
        // Instantiate (gameObject[0],spawnPosL,Quaternion.identity);
        // Instantiate (prefab[pos[random2,i]-1],spawnPoints[pos[random2,i+3]+21].position,Quaternion.identity);
        ui.destroyPlayer();
        if(gameObject[0])
        {
            Instantiate (gameObject[0],spawnPosL,Quaternion.identity);
            // Debug.Log("Create intantiate");
        }
        // Debug.Log("Test");
        // Instantiate (gameObject[0],spawnPosL,Quaternion.identity);
        // Instantiate (gameObject[1],spawnPosR,Quaternion.identity);

        if(gameObject[1])
        {
            Instantiate (gameObject[1],spawnPosR,Quaternion.identity);
            // Debug.Log("Create intantiate");
        }
        // Debug.Log("Test");
    }
}

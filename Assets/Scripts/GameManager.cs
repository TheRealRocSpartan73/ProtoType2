using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    private int score = 0;
    private int numberofLives = 3;
    void Start()
    {
        //Display to console starting values for score and Lives
        Debug.Log("**********Game Start *************************");
        Debug.Log("Player has started with " + numberofLives + " Lives");
        Debug.Log("Player Score is " + score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddLives(int value)
    {
        numberofLives += value;
        if (numberofLives <=0)
        {
            Debug.Log("Game Over! Number of lives left is: " + numberofLives);
        }
        Debug.Log("Lives = " + numberofLives);
    }

    public void AddScore(int value)
    {
        score += value;
        Debug.Log("Score = " + score);
    }
}

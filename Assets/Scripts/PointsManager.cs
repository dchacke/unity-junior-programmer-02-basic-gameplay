using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsManager : MonoBehaviour
{
    public static int score = 0;
    public static int lives = 3;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Score: " + PointsManager.score + "; lives: " + PointsManager.lives);
    }

    public static int incScore() {
        int score = ++PointsManager.score;
        Debug.Log("Increased score to: " + score);

        return score;
    }

    public static int decLives() {
        int lives = --PointsManager.lives;

        Debug.Log("Decreased lives to: " + lives);

        if (lives <= 0) {
            Debug.Log("Game over");
        }

        return score;
    }
}

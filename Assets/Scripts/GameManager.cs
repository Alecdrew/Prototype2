using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int lives;
    private int score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lives = 3;
        Debug.Log("Lives: " + lives);


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddLives(int value)
    {
        lives += value;
        if (lives <= 0)
        {
            Debug.Log("Game Over!");
            lives = 0;
        }
        Debug.Log("Lives: " + lives);
    }
    public void AddScore(int value)
    {
        score += value;
        Debug.Log("Score: " + score);
    }
}

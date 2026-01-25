using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    private GameManager gameManger;
    void Start()
    {
        gameManger = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            gameManger.AddLives(-1);
        }
        else if (other.CompareTag("Food"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            gameManger.AddScore(1);
        }
    }
}

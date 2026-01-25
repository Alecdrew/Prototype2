using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30.0f;
    private float lowerBound = -10.0f;

    private float sideBound = 35.0f;
    private GameManager GameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // Remove a score point if an animal escapes from any side
        if (transform.position.z < lowerBound)
        {
            GameManager.AddScore(-1);
        }
        else if (transform.position.x > sideBound)
        {
            GameManager.AddScore(-1);
        }
        else if (transform.position.x < -sideBound)
        {
            GameManager.AddScore(-1);
        }
        // If object goes past player view, destroy the object
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x > sideBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x < -sideBound)
        {
            Destroy(gameObject);
        }
    }
}

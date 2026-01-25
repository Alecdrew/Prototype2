using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private GameManager GameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.AddLives(-1);
            Destroy(gameObject);
            return;
        }

        // Check if the collided object is an animal and feed it
        if (other.CompareTag("Animal"))
        {
            var hunger = other.GetComponentInParent<AnimalHunger>();
            if (hunger == null) return;
            hunger.FeedAnimal(1);
            Destroy(gameObject); // destroy the food object
        }
    }
}

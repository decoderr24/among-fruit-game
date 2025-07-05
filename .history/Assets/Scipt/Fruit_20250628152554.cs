using UnityEngine;

public class Fruit : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Add logic for what happens when the player collides with the fruit
            Debug.Log("Fruit collected!");
            Destroy(gameObject); // Destroys the fruit object
        }
    }
}

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
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerMovement player = other.GetComponent<PlayerMovement>();
            if (player != null)
            {
                // You can add logic here to increase the player's score or inventory
                // For example: player.IncreaseScore(1);
            }
            Debug.Log("Fruit collected!");
        }
        Destroy(gameObject); 
    }
}

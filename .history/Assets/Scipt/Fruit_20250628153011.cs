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
    void OnTriggerEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerMovement player = other.gameObject.GetComponent<playerMovement>();
            if (player != null)
            {
                player.addF(1); // Assuming you have a method to increase score
            }
            Debug.Log("Fruit collected!");
        }
        Destroy(gameObject); 
    }
}

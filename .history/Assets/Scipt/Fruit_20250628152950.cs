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
            playerMOvement playerMovement = other.gameObject.GetComponent<playerMovement>();
            Debug.Log("Fruit collected!");
        }
        Destroy(gameObject); 
    }
}

using UnityEngine;
usi
public class Obstackle : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player has collided with the obstacle!");
            // Add logic for what happens when the player collides with the obstacle
        }
    }
}

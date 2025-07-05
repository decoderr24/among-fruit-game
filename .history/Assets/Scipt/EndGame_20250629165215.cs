using UnityEngine;

public class EndGame : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Congratulations! You have reached the end.");
            sceneManager.LoadScene("EndGameScene"); // Replace with your end game scene name
            // Here you can add logic to handle the end of the game, like showing a game over screen or restarting
        }
    }
}

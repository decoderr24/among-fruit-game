using UnityEngine;
using unityEngine.SceneManagement;
public class EndGame : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Congratulations! You have reached the end.");
            SceneManager.LoadScene(1); 
        }
    }
}

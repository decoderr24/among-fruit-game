using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("checkpoint"))
        {
            Debug.Log("Checkpoint! Pindah ke scene berikutnya.");
            SceneManager.LoadScene(2);
        }
    }
}

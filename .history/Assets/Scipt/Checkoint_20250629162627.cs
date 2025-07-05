using UnityEngine;

public class Checkoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("checkpoint"))
        {
            Debug.Log("Player menyentuh checkpoint, pindah ke scene berikutnya.");
            SceneManager.LoadScene(2);
        }
    
}

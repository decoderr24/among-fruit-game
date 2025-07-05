using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstackle : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Player Kena Obstackle");
            Destroy(other.gameObject);
        }
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstackle : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.tag == "Player")
       {
           
       }
    }
}

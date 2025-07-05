using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MenuManagement : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void ExitGame()
    {
        debug.Log("Exit Game");
        Application.Quit();
   }
}

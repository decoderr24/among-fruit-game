using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MenuMng : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("Play Game Clicked");
        SceneManager.LoadScene(1);
    }
    public void ExitGame()
    {
        Debug.Log("Exit Game");
        Application.Quit();
    }

}

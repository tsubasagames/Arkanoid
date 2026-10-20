using UnityEngine.SceneManagement;
using UnityEngine;

public class UI : MonoBehaviour
{
    // Loads the first gameplay scene when the player starts the game.
    public void StartGame()
    {
        SceneManager.LoadScene("CS2-MAP");
    }
    public void RestartGame()
    {
       SceneManager.LoadScene("CS2-MAP");
    }
    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void QuitGame()
    {
        Debug.Log("Ragequit");
        Application.Quit();
    }
}
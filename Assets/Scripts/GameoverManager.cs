using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameoverManager : MonoBehaviour
{
    public void loadGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1, LoadSceneMode.Single);
    }

    public void backToMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2, LoadSceneMode.Single);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("BoardLevel");
    }

    public void StartNewGame()
    {
        SaveSystem.ClearSave();
        SceneManager.LoadScene("BoardLevel");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{

    [SerializeField] Canvas pauseCanvas;

    private void Start()
    {
        pauseCanvas.enabled = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
    }

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
        SceneManager.LoadScene("CharacterSelect");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        pauseCanvas.enabled = true;
    }

    public void Resume()
    {
        Time.timeScale = 1;
        pauseCanvas.enabled = false;
    }
}

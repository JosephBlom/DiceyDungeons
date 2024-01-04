using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject duelCanvas;
    [SerializeField] SaveManager saveManager;
    void Start()
    {
        saveManager.LoadPlayer();
        duelCanvas.GetComponent<Canvas>().enabled = false;
    }

    public void activateDuelCanvas()
    {
        duelCanvas.GetComponent<Canvas>().enabled = true;
        Time.timeScale = 0;
    }

    public void resume()
    {
        duelCanvas.GetComponent<Canvas>().enabled = false;
        Time.timeScale = 1;
    }
}

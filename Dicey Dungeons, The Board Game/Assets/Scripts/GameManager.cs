using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject duelCanvas;
    void Start()
    {
        duelCanvas.SetActive(false);
    }

    public void activateDuelCanvas()
    {
        duelCanvas.SetActive(true);
    }
}

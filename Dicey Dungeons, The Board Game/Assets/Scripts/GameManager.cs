using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject duelCanvas;
    void Start()
    {
        duelCanvas.GetComponent<Canvas>().enabled = false;
    }

    public void activateDuelCanvas()
    {
        duelCanvas.GetComponent<Canvas>().enabled = true;
    }
}

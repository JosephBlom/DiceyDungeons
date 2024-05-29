using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseCanvas : MonoBehaviour
{
    [SerializeField] Canvas canvas;

    public void closeCanvas()
    {
        canvas.enabled = false;
    }
}

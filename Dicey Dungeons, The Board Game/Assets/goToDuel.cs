using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goToDuel : MonoBehaviour
{
    public void duel()
    {
        SceneManager.LoadScene("DuelScene");
    }
}

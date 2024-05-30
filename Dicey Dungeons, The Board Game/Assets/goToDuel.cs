using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goToDuel : MonoBehaviour
{
    public SaveManager saveManager;
    public void duel()
    {
        saveManager.SaveGame();
        SceneManager.LoadScene("DuelScene");
    }
}

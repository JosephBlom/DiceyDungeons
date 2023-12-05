using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Duel : MonoBehaviour
{
    [SerializeField]BattleLogic battleLogic;
    [SerializeField] GameObject p1;
    [SerializeField] GameObject p2;

    private void Start()
    {
        p1 = GameObject.FindGameObjectsWithTag("Player")[0];
        p2 = GameObject.FindGameObjectsWithTag("Player")[1];
    }
    public void startDuel()
    {
        battleLogic.GetPlayers(p1, p2);
        SceneManager.LoadScene("DuelScene");
    }
}

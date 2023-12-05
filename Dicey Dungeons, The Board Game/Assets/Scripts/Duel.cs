using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Duel : MonoBehaviour
{
    [SerializeField]BattleLogic battleLogic;
    [SerializeField] GameObject p1;
    [SerializeField] GameObject p2;

    public void startDuel()
    {
        battleLogic.GetPlayers(p1, p2);
        SceneManager.LoadScene("DuelScene");
    }
}

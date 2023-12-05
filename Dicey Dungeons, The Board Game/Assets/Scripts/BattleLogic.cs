using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BattleLogic : MonoBehaviour
{
    static GameObject player1;
    static GameObject player2;

    private void Start()
    {
        player1 = GameObject.FindGameObjectsWithTag("Player")[0];
        player2 = GameObject.FindGameObjectsWithTag("Player")[1];
    }

    public void GetPlayers(GameObject p1, GameObject p2)
    {
        player1 = p1;
        player2 = p2;
    }
}

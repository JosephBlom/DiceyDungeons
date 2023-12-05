using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BattleLogic : MonoBehaviour
{
    static GameObject player2;
    static GameObject player1;
    int playerTurn = 0;
    int[] dice;
    int player1DiceCount;
    int player2DiceCount;

    public void Start()
    {
        Debug.Log(player2);
    }

    public void GetPlayers(GameObject p1, GameObject p2)
    {
        player1 = p1;
        player2 = p2;
        Debug.Log(player1);
    }
    private void Update()
    {
        if(playerTurn % 2 == 0)
        {
            p1Turn();
        }
        else
        {
            p2Turn();
        }
    }

    private void p1Turn()
    {
        //player1DiceCount = player1.GetComponent<Warrior>().Stats.getDiceCount();
        //
        //for(int i = 0; i < player1DiceCount; i++)
        //{
        //    dice[i] = Random.Range(1, 6);
        //}
        //Debug.Log(dice);
    }

    private void p2Turn()
    {
        player2DiceCount = player2.GetComponent<Enemy>().Stats.getDiceCount();
    }
}

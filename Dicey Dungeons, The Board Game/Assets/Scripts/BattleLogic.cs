using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleLogic : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        startBattle();
    }
    public void startBattle()
    {
        Debug.Log("Collision!");
    }
}

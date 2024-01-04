using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public float[] position;
    public float[] inventory;
    public string[] activeCards;

    public PlayerData(Player player)
    {
        position = new float[3];
        position[0] = player.transform.position.x;
        position[1] = player.transform.position.y;
        position[2] = player.transform.position.z;

        activeCards = new string[player.activeCardNames.Length];
        for(int i = 0; i<activeCards.Length; i++)
        {
            activeCards[i] = player.activeCardNames[i];
        }
    }
}

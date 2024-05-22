using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEditor.Experimental.GraphView.GraphView;

public class DuelManager : MonoBehaviour
{
    public Player player1;
    public Player player2;
    public CardSO[] allCards;

    private void Start()
    {
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
        player1 = players[0].GetComponent<Player>();
        player2 = players[1].GetComponent<Player>();


        for (int i = 0; i < player1.activeCardNames.Length; i++)
        {
            for (int x = 0; x < allCards.Length; x++)
            {
                string cardName = allCards[x].getCardName();
                if (player1.activeCardNames[i] == cardName)
                {
                    player1.activeCards.Add(allCards[x]);
                }
            }
        }

        for (int i = 0; i < player2.activeCardNames.Length; i++)
        {
            for (int x = 0; x < allCards.Length; x++)
            {
                string cardName = allCards[x].getCardName();
                if (player2.activeCardNames[i] == cardName)
                {
                    player2.activeCards.Add(allCards[x]);
                }
            }
        }

    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            SceneManager.LoadScene("BoardLevel");
        }
    }
}

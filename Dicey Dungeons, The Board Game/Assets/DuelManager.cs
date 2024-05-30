using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class DuelManager : MonoBehaviour
{
    public Player player1;
    public Player player2;
    public Slider p1HP;
    public Slider p2HP;
    public TextMeshProUGUI p1HPText;
    public TextMeshProUGUI p2HPText;
    public CardSO[] allCards;

    private void Start()
    {
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
        player1 = players[0].GetComponent<Player>();
        player2 = players[1].GetComponent<Player>();

        p1HP.maxValue = player1.maxHealth;
        p2HP.maxValue = player2.maxHealth;

        p1HP.value = player1.health;
        p2HP.value = player2.health;

        p1HPText.text = player1.health + " / " + player1.maxHealth;
        p2HPText.text = player2.health + " / " + player2.maxHealth;

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

        p1HP.value = player1.health;
        p2HP.value = player2.health;

        p1HPText.text = player1.health + " / " + player1.maxHealth;
        p2HPText.text = player2.health + " / " + player2.maxHealth;

        if(player1.health <= 0 || player2.health <= 0)
        {
            SceneManager.LoadScene("BoardLevel");
        }
    }
}

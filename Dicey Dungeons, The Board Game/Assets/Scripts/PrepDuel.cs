using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrepDuel : MonoBehaviour
{
    public CardList cardList;
    public List<Button> buttons = new List<Button>();

    [Header("Player Variables")]
    [SerializeField] GameBehavior gameBehavior;
    [Tooltip("Player 1 = 0, Player 2 = 1;")]
    [SerializeField] int objectIndex;
    
    List<CardSO> cards = new List<CardSO>();

    public void getCards()
    {
        Player player = gameBehavior.players[objectIndex].GetComponent <Player>();
        for(int i = 0; i < player.activeCardNames.Length; i++)
        {
            for(int b = 0; b < cardList.allCards.Count; b++)
            {
                if (cardList.allCards[b].Equals(player.activeCardNames[i]))
                {
                    cards.Add(cardList.allCards[b]);
                }
            }
        }
    }

    public void assignButtons()
    {
        //Assign the buttons the cards that the player has active
        //Need to implement general abilities like attack and defend that each card can have.
        //ex. if attack the card will apply damage.
        //Make them function so that assigning onclick event will be easier to do. 
        //Make sure there are NO paramaters as it will be harder to run things.
    }
}

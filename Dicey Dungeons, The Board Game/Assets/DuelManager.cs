using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEditor.Experimental.GraphView.GraphView;

public class DuelManager : MonoBehaviour
{
    [SerializeField] Player player1;
    public CardSO[] allCards;
    private void Start()
    {
        for(int i = 0; i < allCards.Length; i++)
        {
            if(player1.activeCardNames[i] == allCards[i].getCardName())
            {
                player1.activeCards[i] = allCards[i];
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

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
        Debug.Log("Scene Start");
        for(int i = 0; i < player1.activeCardNames.Length; i++)
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
        
    }
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            SceneManager.LoadScene("BoardLevel");
        }
    }
}

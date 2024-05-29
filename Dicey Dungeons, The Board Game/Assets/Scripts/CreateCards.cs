using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CreateCards : MonoBehaviour
{
    public DuelManager duelManager;
    public Transform parentObject;
    public Button button;
    public bool p1;

    private void Start()
    {
        duelManager = FindObjectOfType<DuelManager>();
        createCards();
    }

    void createCards()
    {
        if (p1)
        {
            Player player = duelManager.player1;
            foreach(CardSO card in player.activeCards)
            {
                Button currentButton = Instantiate(button, Vector3.zero, Quaternion.identity, parentObject);
                currentButton.GetComponentInChildren<TextMeshProUGUI>().text = card.getCardName();
                currentButton.onClick.AddListener(card.useCard);
            }
        }
        else
        {
            Player player = duelManager.player2;
            foreach (CardSO card in player.activeCards)
            {
                Button currentButton = Instantiate(button, Vector3.zero, Quaternion.identity, parentObject);
                currentButton.GetComponentInChildren<TextMeshProUGUI>().text = card.getCardName();
                currentButton.onClick.AddListener(card.useCard);
            }
        }
    }

    IEnumerator delayStart()
    {
        yield return new WaitForSeconds(2);
        createCards();
    }
}

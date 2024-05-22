using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CreateCards : MonoBehaviour
{
    public DuelManager duelManager;
    public Button button;
    public bool p1;

    private void Start()
    {
        duelManager = FindObjectOfType<DuelManager>();
    }

    void createCards()
    {
        if (p1)
        {
            Player player = duelManager.player1;
            foreach(CardSO card in player.activeCards)
            {
                Instantiate(button, Vector3.zero, Quaternion.identity);
                button.GetComponentInChildren<TextMeshProUGUI>().text = card.getCardName();
            }
        }
    }

    IEnumerator delayStart()
    {
        yield return new WaitForSeconds(2);
        createCards();
    }
}

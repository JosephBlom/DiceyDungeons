using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameBehavior : MonoBehaviour
{
    [Header("Turn Variables")]
    public List<GameObject> players;
    public int currentPlayerTurn;

    [Header("Player Stats")]
    public PlayerMovement currentPlayer;
    public Transform currentPlayerTransform;
    public List<Button> p1Cards = new List<Button>();
    public List<Button> p2Cards = new List<Button>();

    [Header("Misc Variables")]
    public Camera cameraMain;
    public float cameraZOffset = -10;

    void Start()
    {
        findAllPlayers();
        currentPlayer = players[currentPlayerTurn].GetComponent<PlayerMovement>();
        currentPlayerTransform = players[currentPlayerTurn].transform;
        currentPlayer.isTurn = true;
        if(SceneManager.GetActiveScene().name == "BoardLevel")
        {
            setCamPos();
        }
        else if(SceneManager.GetActiveScene().name == "DuelScene")
        {
            collectCards();
            switchButtons(currentPlayerTurn + 1);
        }


    }

    public void nextMoveTurn()
    {
        currentPlayer.isTurn = false;
        currentPlayer.usedMoves = 0;
        currentPlayerTurn++;
        if (currentPlayerTurn > players.Count - 1)
        {
            currentPlayerTurn = 0;
        }
        currentPlayer = players[currentPlayerTurn].GetComponent<PlayerMovement>();
        currentPlayer.isTurn = true;
        currentPlayerTransform = players[currentPlayerTurn].transform;
        setCamPos();
    }

    public void nextCardTurn()
    {
        switchButtons(currentPlayerTurn);
        currentPlayerTurn++;
        if (currentPlayerTurn > players.Count - 1)
        {
            currentPlayerTurn = 0;
        }
        managePlayers();
    }

    public void setCamPos()
    {
        cameraMain.transform.position = new Vector3(currentPlayerTransform.position.x, currentPlayerTransform.position.y, cameraZOffset);
    }

    public void findAllPlayers()
    {
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject gameObject in gameObjects)
        {
            players.Add(gameObject);
        }
    }

    public void managePlayers()
    {
        Player player = players[currentPlayerTurn].GetComponent<Player>();
        List<CardSO> playerCards = player.activeCards;

        if (player.Shocked)
        {
            int shockedCard = Random.Range(0, player.activeCards.Count);

        }
    }

    void collectCards()
    {
        Button[] p1SortCards = GameObject.FindGameObjectWithTag("P1CardContainer").GetComponentsInChildren<Button>();
        Button[] p2SortCards = GameObject.FindGameObjectWithTag("P2CardContainer").GetComponentsInChildren<Button>();

        for (int i = 0; i < p1SortCards.Length; i++)
        {
            p1Cards.Add(p1SortCards[i]);
        }

        for (int i = 0; i < p2SortCards.Length; i++)
        {
            p2Cards.Add(p2SortCards[i]);
        }
    }

    void switchButtons(int playerIndex)
    {
        if(playerIndex == 0)
        {
            foreach(Button card in p1Cards)
            {
                card.enabled = false;
            }
            foreach(Button card in p2Cards)
            {
                card.enabled = true;
            }
        }
        else
        {
            foreach(Button card in p2Cards)
            {
                card.enabled = false;
            }
            foreach(Button card in p1Cards)
            {
                card.enabled = true;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBehavior : MonoBehaviour
{
    [Header("Turn Variables")]
    public List<GameObject> players;
    public int currentPlayerTurn;

    [Header("Player Stats")]
    public PlayerMovement currentPlayer;
    public Transform currentPlayerTransform;

    [Header("Misc Variables")]
    public Camera cameraMain;
    public float cameraZOffset;

    void Start()
    {
        currentPlayer = players[currentPlayerTurn].GetComponent<PlayerMovement>();
        currentPlayerTransform = players[currentPlayerTurn].transform;
        currentPlayer.isTurn = true;
        setCamPos();
    }

    public void nextTurn()
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

    public void setCamPos()
    {
        cameraMain.transform.position = new Vector3(currentPlayerTransform.position.x, currentPlayerTransform.position.y, cameraZOffset);
    }
}

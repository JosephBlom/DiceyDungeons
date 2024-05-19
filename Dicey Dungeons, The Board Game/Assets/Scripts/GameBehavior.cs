using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    public void findAllPlayers()
    {
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject gameObject in gameObjects)
        {
            players.Add(gameObject);
        }
    }
}

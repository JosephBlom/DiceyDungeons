using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public GameObject[] players;
    private void Start()
    {
        players = GameObject.FindGameObjectsWithTag("Player");
        
        LoadGame();
    }

    private void OnApplicationQuit()
    {
        SaveGame();
    }
    
    public void SaveGame()
    {
        foreach(GameObject player in players)
        {
            SaveSystem.SavePlayer(player.GetComponent<Player>());
        }
    }

    public void LoadGame()
    {
        foreach (GameObject player in players)
        {
            LoadPlayer(player.GetComponent<Player>());
        }
    }

    public void LoadPlayer(Player player)
    {
        PlayerData data = SaveSystem.LoadPlayer(player);

        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
        player.transform.position = position;

        player.activeCardNames = data.activeCards; 
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveManager : MonoBehaviour
{
    public GameObject[] players;
    [SerializeField] GameBehavior manager;
    CharacterList characterList;
    string[] allCharacters = { "Warrior", "Jester", "Bear", "Inventor", "Robot", "Thief", "Witch" };

    private void Start()
    {
        if (!SceneManager.GetActiveScene().name.Equals("CharacterSelect"))
        {
            characterList = GameObject.FindGameObjectWithTag("CharacterList").GetComponent<CharacterList>();
            SpawnPlayers();
            players = GameObject.FindGameObjectsWithTag("Player");
            LoadGame();
            manager.BeginScene();
        }
    }

    private void OnApplicationQuit()
    {
        SaveGame();
    }
    
    public void SpawnPlayers()
    {
        for(int i = 0; i < characterList.allCharacters.Count; i++)
        {
            for(int z = 0; z < allCharacters.Length; z++)
            {
                if (characterList.allCharacters[i].name.Equals(allCharacters[z]))
                {
                    GameObject player = Instantiate(characterList.allCharacters[i], Vector3.zero, Quaternion.identity);
                    player.name = characterList.allCharacters[i].name;
                }
            }
        }
    }

    public void SaveBetweenScenes()
    {
        if(players.Length <= 1)
        {
            players = GameObject.FindGameObjectsWithTag("Player");
        }
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

    public void loadBoardLevel()
    {
        SceneManager.LoadScene("BoardLevel");
    }
}

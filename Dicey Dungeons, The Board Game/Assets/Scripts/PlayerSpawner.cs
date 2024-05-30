using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSpawner : MonoBehaviour
{
    [SerializeField] GameObject playerPrefab;

    public void SpawnCharacter()
    {
        GameObject character = Instantiate(playerPrefab, new Vector3(100, 100, 0), Quaternion.identity);
        gameObject.GetComponent<Button>().interactable = false;
        character.name = playerPrefab.name;
    }
}

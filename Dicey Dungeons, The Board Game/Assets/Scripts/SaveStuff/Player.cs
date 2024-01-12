using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector3 position;
    public string[] activeCardNames;
    public List<CardSO> activeCards = new List<CardSO>();
    public int health;
    private void Start()
    {
        position = transform.position;
    }
}

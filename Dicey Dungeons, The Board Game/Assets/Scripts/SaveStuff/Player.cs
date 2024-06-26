using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Character Stats")]
    public int health;
    public int maxHealth;
    public int movesPerTurn;

    [Header("Current Effects")]
    public bool Frozen;
    public bool Shocked;
    public bool Cursed;
    public bool Poisoned;

    [Header("Misc Variables")]
    public Vector3 position;
    public string[] activeCardNames;
    public List<CardSO> activeCards = new List<CardSO>();
    
    private void Start()
    {
        position = transform.position;
    }
}

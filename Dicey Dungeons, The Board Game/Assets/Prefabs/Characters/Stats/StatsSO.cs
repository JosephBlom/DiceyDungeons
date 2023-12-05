using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(menuName = "StatsSO", fileName = "Stats")]
public class StatsSO : ScriptableObject
{
    public int Health;
    public int MaxHealth;
    public int XP;
    public int Level;
    public int diceCount;

    public int getHealth()
    {
        return Health;
    }
    public int getMaxHealth()
    {
        return MaxHealth;
    }
    public int getXP()
    {
        return XP;
    }
    public int getLevel()
    {
        return Level;
    }
    public int getDiceCount()
    {
        return diceCount;
    }
}

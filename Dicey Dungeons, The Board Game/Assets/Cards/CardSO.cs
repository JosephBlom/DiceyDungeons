using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UIElements;
using JetBrains.Annotations;

[CreateAssetMenu(menuName = "Card SO", fileName = "New Card")]
public class CardSO : ScriptableObject
{
    //Serialized Fields
    public string cardName;
    [TextArea(2, 3)]
    public string ability;
    [Header("Effects:")]
    public bool Damage;
    public bool Freeze;
    public bool Shock;
    public bool Curse;
    public bool Poison;
    public bool Reusable;
    [Range(1,6)]
    public int[] diceRequired;
    public int diceMax;
    public int diceMin;
    public int amountRequired;
    //Variables
    bool[] effects;

    public string getCardName()
    {
        return cardName;
    }
    public string getAbility()
    {
        return ability;
    }
    public int[] getDiceRequired()
    {
        return diceRequired;
    }
    public bool[] getEffects()
    {
        effects[0] = damage();
        effects[1] = freeze();
        effects[2] = shock();
        effects[3] = curse();
        effects[4] = poison();
        effects[5] = reusable();
        return effects;
    }
    public int getAmount()
    {
        return amountRequired;
    }
    public bool damage()
    {
        return Damage;
    }
    public bool freeze()
    {
        return Freeze;
    }
    public bool shock()
    {
        return Shock;
    }
    public bool curse()
    {
        return Curse;
    }
    public bool poison()
    {
        return Poison;
    }
    public bool reusable()
    {
        return Reusable;
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UIElements;

[CreateAssetMenu(menuName = "Card SO", fileName = "New Card")]
public class CardSO : ScriptableObject
{
    //Serialized Fields
    [SerializeField] string cardName;
    [TextArea(2, 3)]
    [SerializeField] string ability;
    [Header("Effects:")]
    [SerializeField] bool Damage;
    [SerializeField] bool Freeze;
    [SerializeField] bool Shock;
    [SerializeField] bool Curse;
    [SerializeField] bool Poison;
    [Range(1,6)]
    [SerializeField] int[] diceRequired;
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

        return effects;
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
}

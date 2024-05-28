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
    public bool attack;
    public bool effect;
    [Header("Effects:")]
    public int Damage;
    public int healing;
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
        effects[0] = freeze();
        effects[1] = shock();
        effects[2] = curse();
        effects[3] = poison();
        effects[4] = reusable();
        return effects;
    }
    public int getAmount()
    {
        return amountRequired;
    }
    public int damage()
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
    public void useCard()
    {
        GameBehavior controller = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameBehavior>();
        Player currentPlayer = controller.players[controller.currentPlayerTurn].GetComponent<Player>();
        Player attackedPlayer;
        if(controller.currentPlayerTurn++ > 1)
        {
            attackedPlayer = controller.players[0].GetComponent<Player>();
        }
        else
        {
            attackedPlayer = controller.players[0].GetComponent<Player>();
        }
        
        if(attack)
        {
            attackedPlayer.health -= Damage;
            bool[] effectList = getEffects();
            if (effectList[0])
            {
                attackedPlayer.Frozen = true;
            }
            if (effectList[1])
            {
                attackedPlayer.Shocked = true;
            }
            if (effectList[2])
            {
                attackedPlayer.Cursed = true;
            }
            if (effectList[3])
            {
                attackedPlayer.Poisoned = true;
            }
        }
        else
        {
            currentPlayer.health += healing;
        }
    }
}

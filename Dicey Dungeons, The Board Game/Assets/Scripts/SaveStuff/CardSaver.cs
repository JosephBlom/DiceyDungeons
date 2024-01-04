using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSaver
{

    public string cardName;
    public string ability;
    public bool Damage;
    public bool Freeze;
    public bool Shock;
    public bool Curse;
    public bool Poison;
    public bool Reusable;
    public int diceMax;
    public int diceMin;
    public int amountRequired;

    public CardSaver(CardSO card)
    {
        cardName = card.cardName;
        ability = card.ability;
        Damage = card.Damage;
        Freeze = card.Freeze;
        Shock = card.Shock;
        Curse = card.Curse;
        Poison = card.Poison;
        Reusable = card.Reusable;
        diceMax = card.diceMax;
        diceMin = card.diceMin;
        amountRequired = card.amountRequired;
    }
}

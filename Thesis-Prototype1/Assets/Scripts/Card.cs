using System;
using UnityEngine;

//code based on Nico and "Tutorial - Deck Building" by Sinuous

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    public string cardName;
    public int cardType;
    public int cardNumber;
    public Sprite cardImage;
    
}

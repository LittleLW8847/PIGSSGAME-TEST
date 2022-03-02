using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class Card
{
    public int cardElement = 0; // 1: Fire/ 2: Water/ 3: Earth 4: Thunder/ 5: DARK 
    public int cardColor = 0;   // 1: Red/ 2: Blue/ 3: Brown/ 4: Yellow/ 5: urple 
    public int cardRank;
    public string elementRead;
    public string colorRead;
    public string rankRead;

    public Card()
    {
        new Card();
        Card card = new Card();
    }

    public Card(int element, int colour, int rank)
    {
        this.cardElement = element;
        this.cardColor = colour;
        this.cardRank = rank;

        switch (cardColor)
        {
            case 1: this.colorRead = "Red"; break;
            case 2: this.colorRead = "Blue"; break;
            case 3: this.colorRead = "Brown"; break;
            case 4: this.colorRead = "Yellow"; break;
            case 5: this.colorRead = "Purple"; break;
        }

        switch (cardElement)
        {
            case 1: this.elementRead = "Fire"; break;
            case 2: this.elementRead = "Water"; break;
            case 3: this.elementRead = "Earth"; break;
            case 4: this.elementRead = "Thunder"; break;
            case 5: this.elementRead = "Dark"; break;
        }
        switch (cardRank)
        {
            case 1: this.rankRead = "1"; break;
            case 2: this.rankRead = "2"; break;
            case 3: this.rankRead = "3"; break;
            case 4: this.rankRead = "4"; break;
            case 5: this.rankRead = "5"; break;
            case 6: this.rankRead = "6"; break;
            case 7: this.rankRead = "7"; break;
            case 8: this.rankRead = "8"; break;
            case 9: this.rankRead = "9"; break;
            case 10: this.rankRead = "10"; break;
            case 11: this.rankRead = "F"; break;
            case 12: this.rankRead = "B"; break;
            case 13: this.rankRead = "E"; break;
            case 14: this.rankRead = "T"; break;
            case 15: this.rankRead = "D"; break;
        }
    }

    public void displayInfo()
    {
        Console.WriteLine("Card Color: " + colorRead);
        Console.WriteLine("Card Element:" + elementRead);
        Console.WriteLine("Card Rank:" + rankRead);
    }

    /*// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (cardColor)
        {
            case 1: colorRead = "Red"; break;
            case 2: colorRead = "Blue"; break;
            case 3: colorRead = "Brown"; break;
            case 4: colorRead = "Yellow"; break;
            case 5: colorRead = "Purple"; break;
        }

        switch (cardElement)
        {
            case 1: elementRead = "Fire"; break;
            case 2: elementRead = "Water"; break;
            case 3: elementRead = "Earth"; break;
            case 4: elementRead = "Thunder"; break;
            case 5: elementRead = "Dark"; break;
        }
        switch (cardRank)
        {
            case 1: rankRead = "1"; break;
            case 2: rankRead = "2"; break;
            case 3: rankRead = "3"; break;
            case 4: rankRead = "4"; break;
            case 5: rankRead = "5"; break;
            case 6: rankRead = "6"; break;
            case 7: rankRead = "7"; break;
            case 8: rankRead = "8"; break;
            case 9: rankRead = "9"; break;
            case 10: rankRead = "10"; break;
            case 11: rankRead = "F"; break;
            case 12: rankRead = "B"; break;
            case 13: rankRead = "E"; break;
            case 14: rankRead = "T"; break;
            case 15: rankRead = "D"; break;
        }
    }*/
}

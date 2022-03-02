using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public List<Card> deck = new List<Card>();//deck

    [SerializeField]
    public int mainElement = 5;//amount of element in game
    public int mainRank = 15;//amount of Rank in the game
    public int mainColor = 5;//amout of color in thegame

    // Start is called before the first frame update
    void Start()
    {
        Console.Write("test");   
    }

    // Update is called once per frame
    void Update()
    {
        deckGenerator();
    }

    public void deckGenerator()         //for generating card in the deck.
    {
        int ID = 0;
        int cardsAmount = mainElement * mainColor * mainElement;
        for(int colorcount = 1; colorcount <= mainColor; colorcount++)
        {
           for(int elementcount = 1; elementcount <= mainElement; elementcount++)
            {
                for(int rankcount = 1; rankcount <= mainRank; rankcount++)
                {
                    deck.Add(new Card(elementcount, colorcount, rankcount));
                    Console.WriteLine("Card Color: " + deck[ID].colorRead);
                    Console.WriteLine("Card Element:" + deck[ID].elementRead);
                    Console.WriteLine("Card Rank:" + deck[ID].rankRead);
                    Console.WriteLine("----------------------------------------------------------------");
                }
            }
        }               
    }

}

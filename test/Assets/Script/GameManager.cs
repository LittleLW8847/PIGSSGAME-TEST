using System.Collections;
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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void deckGenerator()         //for generating card in the deck.
    {
        int cardsAmount = mainElement * mainColor * mainElement;
        int elementcount = 1;
        int rankCount = 1;
        for(int i = 0; i <= cardsAmount - 1; i++)
        {
            if(i <= elementcount*mainRank - 1)
            {
                deck.Add(new Card(i, elementcount, elementcount, rankCount)); ;
                rankCount++;
            }
            if(i == elementcount * mainRank - 1) //reset rank and change both color and elementevery time after finish generate all the rank
            {                                    //for the element.
                rankCount = 1;                      
                elementcount++;
            }
            
        }
               
    }
}

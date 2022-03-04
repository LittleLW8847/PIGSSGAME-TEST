using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<Card> deck = new List<Card>();//deck
    private List<Card> hands = new List<Card>();//card on hand
   // CardDisplay renderer = new CardDisplay();

    [SerializeField]
    public int mainElement = 5;//amount of element in game
    public int mainRank = 15;//amount of Rank in the game
    public int mainColor = 5;//amout of color in thegame

    public Image cardtemplate;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("test");
        deckGenerator();
        //renderer.CardReder(deck[Random.Range(0, 374)]);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void deckGenerator()         //for generating card in the deck.
    {
        int ID = 0;
        int cardsAmount = mainElement * mainColor * mainElement;
        for (int colorcount = 1; colorcount <= mainColor; colorcount++)
        {
            for (int elementcount = 1; elementcount <= mainElement; elementcount++)
            {
                for (int rankcount = 1; rankcount <= mainRank; rankcount++)
                {
                    deck.Add(new Card(ID+1, elementcount, colorcount, rankcount));
                    Debug.Log("Card Color: " + deck[ID].colorRead + " Card Element:" + deck[ID].elementRead+ " Card Rank:" + deck[ID].rankRead);
                    Debug.Log("----------------------------------------------------------------");
                    ID++;
                }
            }
        }
    }

    private void draw()
    {
        int rnd = Random.Range(0, mainElement * mainColor * mainColor);
        if (deck[rnd].deckActive)
        {
            hands.Add(deck[rnd]);
            deck[rnd].deckActive = false;
            deck[rnd].handActive = true;
        }
        else
        {
            rnd = rnd + Random.Range(0, 5);
            draw();
        }
    }

    private void shuffleIntoDeck()
    {
        
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public List<Card> cardTarget = new List<Card>(); //reference to specific card to be displayed.

    public int tempInt;
    public string tempElement;
    public string tempRank;
    public string tempColor;

    public Text displayColor;
    public Text displayRank;
    public Text displayelemet;
    public Image cardTemplate;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void cardReader(Card card)
    {
        tempInt = card.cardID;
        tempElement = card.elementRead;
        tempRank = card.rankRead;
        tempColor = card.colorRead;

        displayColor.text = tempColor;
        displayelemet.text = tempElement;
        displayRank.text = tempRank;
    }
}
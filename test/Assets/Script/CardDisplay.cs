using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    Card cardTarget; //reference to specific card to be displayed.

    public Text displayColor;
    public Text displayRank;
    public Text displayelemet;



    // Start is called before the first frame update
    void Start()
    {
        //read card information from link list.
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CardReder(Card targetCard)//read card information for displaying
    {
        displayColor.text = cardTarget.colorRead;
        displayRank.text = cardTarget.rankRead;
        displayelemet.text = cardTarget.elementRead;
    }

    public void cardRenderer()
    {

    }
}

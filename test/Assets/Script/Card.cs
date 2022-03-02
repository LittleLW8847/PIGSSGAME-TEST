using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public int cardID;  //not really know what to do with this variable, but could be handy for identified cards

    public int cardElement = 0; // 1: Fire/ 2: Water/ 3: Earth 4: Thunder/ 5: DARK 
    public int cardColor = 0;   // 1: Red/ 2: Blue/ 3: Brown/ 4: Yellow/ 5: urple 
    public string elementRead;
    public string colorRead;
    public string cardRank; 

    public Card()
    {

    }

    public void createCard(int ID, int element, int colour, string rank)
    {
        cardID = ID;
        cardElement = element;
        cardColor = colour;
        cardRank = rank;

        switch (cardColor)
        {
            case 1:
                colorRead = "Red";
                break;
            case 2:
                colorRead = "Blue";
                break;
            case 3:
                colorRead = "Brown";
                break;
            case 4:
                colorRead = "Yellow";
                break;
            case 5:
                colorRead = "Purple";
                break;
        }

        switch (cardElement)
        {
            case 1:
                elementRead = "Fire";
                break;
            case 2:
                elementRead = "Water";
                break;
            case 3:
                elementRead = "Earth";
                break;
            case 4:
                elementRead = "Thunder";
                break;
            case 5:
                elementRead = "Dark";
                break;
        }
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
            case 1: colorRead = "Red";
                break;
            case 2: colorRead = "Blue";
                break;
            case 3: colorRead = "Brown";
                break;
            case 4: colorRead = "Yellow";
                break;
            case 5: colorRead = "Purple";
                break;
        }

        switch (cardElement)
        {
            case 1: elementRead = "Fire";
                break;
            case 2: elementRead = "Water";
                break;
            case 3: elementRead = "Earth";
                break;
            case 4: elementRead = "Thunder";
                break;
            case 5: elementRead = "Dark";
                break;
        }
    }*/
}

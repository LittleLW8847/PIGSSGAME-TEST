using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public int cardID;  //not really know what to do with this variable, but could be handy for identified cards
    
    public bool fire = false; //
    public bool water = false;//
    public bool earth = false;//bool variable for checking card's element.
    public bool thunder = false;//
    public bool dark = false;//
    
    public string cardRank; 

    public Card()
    {

    }

    public void createCard(int ID, bool isFire, bool isWater, bool isEarth, bool isThunder, bool isDark, string rank)
    {
        cardID = ID;
        fire = isFire;
        water = isWater;
        earth = isEarth;
        thunder = isThunder;
        dark = isDark;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

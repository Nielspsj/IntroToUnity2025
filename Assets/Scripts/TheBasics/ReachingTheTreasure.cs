using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReachingTheTreasure : MonoBehaviour
{
    public bool pureOfHeart = true;
    public bool hasSecretIncantation = false;
    public string rareItem = "medallionOfHope";

    // Start is called before the first frame update
    void Start()
    {
        OpenTreasureChamber();
    }   

    public void OpenTreasureChamber()
    {
        if(pureOfHeart == true && rareItem == "medallionOfHope")
        {
            if(!hasSecretIncantation)
            {
                Debug.Log("Spirit but not the knowledge. Come back when you've learned the incantation.");
            }
            else
            {
                Debug.Log("You open the chamber and reap the riches!");
            }
        }
        else
        {
            Debug.Log("You try to open it but a trap teleports you away.");
        }
    }
}

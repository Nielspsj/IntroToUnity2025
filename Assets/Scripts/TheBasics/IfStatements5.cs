using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements5 : MonoBehaviour
{
    //Multiple conditions

    public bool weaponEquipped = true;
    public string weaponType = "Longsword";

    // Start is called before the first frame update
    void Start()
    {
        if(weaponEquipped && weaponType == "Longsword")
        {            
            Debug.Log("For the queen!");                       
        }
        else
        {
            Debug.Log("Fists aren't going to work against armor...");
        }
    }
}

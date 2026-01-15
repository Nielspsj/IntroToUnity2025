using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements4 : MonoBehaviour
{
    //Nested statement
    //Assignment: Add multiple conditions in an if-statement.
    //Check both that the weapon is equiped and that the weaponType is a "Longsword" in the same condition.

    public bool weaponEquipped = true;
    public string weaponType = "Longsword";

    // Start is called before the first frame update
    void Start()
    {
        if(weaponEquipped)
        {
            if(weaponType == "Longsword")
            {
                Debug.Log("For the queen!");
            }            
        }
        else
        {
            Debug.Log("Fists aren't going to work against armor...");
        }
    }
}

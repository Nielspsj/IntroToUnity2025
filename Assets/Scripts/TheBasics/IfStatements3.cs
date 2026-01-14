using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements3 : MonoBehaviour
{
    //NOT operator

    public bool hasDungeonKey = false;
    public string weaponType = "Arcante Staff";

    // Start is called before the first frame update
    void Start()
    {
        if(hasDungeonKey)
        {
            Debug.Log("You possess the secret key - ENTER.");
        }

        if(weaponType != "Longsword")
        {
            Debug.Log("You don't appear to have the right weapon...");
        }
    }
}

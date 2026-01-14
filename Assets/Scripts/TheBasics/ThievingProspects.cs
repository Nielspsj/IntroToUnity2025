using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder.MeshOperations;

public class ThievingProspects : MonoBehaviour
{
    private int currentGold = 42;

    // Start is called before the first frame update
    void Start()
    {
        if(currentGold > 50)
        {
            Debug.Log("You're rich! Beware of pickpockets.");
        }
        else if (currentGold < 15)
        {
            Debug.Log("You're super poor, but poor is safe.");
        }
        else
        {
            Debug.Log("Is your purse in the sweet spot now?");
        }
    }
}

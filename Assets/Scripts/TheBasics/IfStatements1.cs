using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements1 : MonoBehaviour
{
    //If statement

    public bool hasDungeonKey = true;
    // Start is called before the first frame update
    void Start()
    {
        int ballAmount = 3;
        Debug.Log("ballAmount is now " + ballAmount);
        Debug.Log("Another message");
        ballAmount = 10;
        Debug.Log(ballAmount);
    }    

    private void TestMethod()
    {
        if (hasDungeonKey)
        {
            Debug.Log("You possess the secret key - ENTER.");
        }
    }
}

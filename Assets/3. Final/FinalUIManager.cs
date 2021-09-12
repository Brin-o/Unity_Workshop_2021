using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // important! this needs to be added so you can manipulate UI related components

public class FinalUIManager : MonoBehaviour
{

    public Text scoreDisplay;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scoreDisplay.text = "Score: " + FinalGameManager.instance.score;
    }
}

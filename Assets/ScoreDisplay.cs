using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public Text scoreDisplay;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scoreDisplay.text = "Score " + GameManager.instance.highscore;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CeciUnScript : MonoBehaviour
{
    // Variables are a way to save things to an assigned word
    public int wholeNumber = 69;
    public float decimalNumber = 4.20f; //numbers with decimals (floats) need a "f" behind them
    public string funnyWord = "lol";

    // We can also reference components that Unity already provides 
    public SpriteRenderer sprite; //but unity does not know, on its own, what SpriteRenderer we are talking about so we need to, somehow, assign it.    


    // SIMPLE TIMER
    public float timer = 0; //a variable where we will add time to it every frame

    
    void Start() //start is ran once when the object is created
    {
        print(funnyWord); //print can be used to get an output of a variable into the console. 
    }

    void Update() // Update is called once per frame
    {
        //makes the object bigger when space is pressed
        if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.localScale += new Vector3 (1,1,1);
        }
        ColorTimer();
    }

    void ColorTimer() //this will never run because its not being refferenced! Typing the name of the method in update() will make it be called every single frame
    {
        timer += Time.deltaTime; //adds the time that passed between each frame to the timer variable
        if(timer > 1.5f)
        {
            sprite.color = Color.green;
        }
    }
}

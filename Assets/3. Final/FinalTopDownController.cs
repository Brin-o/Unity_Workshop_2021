using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalTopDownController : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;

    public Vector2 inputVector;
    public float speed = 25f;
    public float friction = 0.9f;
    public Vector2 velocity;

    // Update is called once per frame
    void Update()
    {
        inputVector.x = Input.GetAxisRaw("Horizontal"); //sets the x coordinate of the vector to -1 if left is pressed, to 1 if right is pressed, 0 if none are pressed
        inputVector.y = Input.GetAxisRaw("Vertical"); //same but for the y coordinate
        inputVector = inputVector.normalized;
    }

    //movement code should always happen in fixed update (as opposed to getting the input)
    void FixedUpdate() 
    {
        //if input is not zero we accelerate wherever we are going
        if(inputVector != Vector2.zero)
        {
            velocity = inputVector * speed;
            //Clamp restricts the variable to a minimum/maximum number
        }
        //otherwise we apply friction
        else
        {
            velocity *= friction; 
        }
        rigidbody2D.velocity = velocity;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunningDude : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public Vector2 inputAxis;
    public float speed;

    public float friction;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        inputAxis.x = Input.GetAxisRaw("Horizontal");
        inputAxis.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        if (inputAxis != Vector2.zero)
        {
            rigidbody2D.velocity = inputAxis * speed;
        }
        else
        {
            rigidbody2D.velocity = rigidbody2D.velocity * friction;
        }
    }
}

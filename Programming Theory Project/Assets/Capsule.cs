using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE from shape
public class Capsule : Shape
{
    //ENCAPSULATION
    public string ShapeName { get; set; }
    private bool leftDirection;
    // Start is called before the first frame update
    void Start()
    {
        color = new Color(0.2f, 0.8f, 0.6f);
        this.GetComponent<Renderer>().material.color = color;
        ShapeName = "Capsule";
        DisplayText();
    }

    //POLYMORPHISM on virtual DisplayText function
    public override void DisplayText()
    {
        Debug.Log("I am a " + ShapeName);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    //Abstraction and polymorphism
    protected override void Move()
    {
        if (transform.position.x < 2)
        {
            leftDirection = false;
        }
        else if (transform.position.x > 8)
        {
            leftDirection = true;
        }
        if  (leftDirection)
        {
            transform.position = new Vector3(transform.position.x - 0.03f, transform.position.y, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(transform.position.x + 0.03f, transform.position.y, transform.position.z);
        }

    }
}
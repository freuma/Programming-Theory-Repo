using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE from shape 
public class Square : Shape
{
    //ENCAPSULATION
    public string ShapeName { get; set; }
    
    // Start is called before the first frame update
    void Start()
    {
        color = new Color(0.1f, 0.2f, 0.3f);
        gameObject.GetComponent<Renderer>().material.color = color;
        ShapeName = "Square";
        DisplayText();
        
    }

    //POLYMORPHISM on virtual DisplayText function
    public override void DisplayText()
    {
        Debug.Log("I feel like a " + ShapeName);
    }

    // Update is called once per frame
    void Update()
    {
        //Abstraction
        Move();
    }

  
}

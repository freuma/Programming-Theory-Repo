using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE from shape
public class Sphere : Shape
{
    //ENCAPSULATION
    public string ShapeName { get; set; }
    // Start is called before the first frame update
    void Start()
    {
        color = new Color(0.5f, 0.6f, 0.4f);
        this.GetComponent<Renderer>().material.color = color;
        ShapeName = "Sphere";
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
}

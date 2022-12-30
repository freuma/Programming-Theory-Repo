using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    //ENCAPSULATION
    public Color color { get; set;}
    private bool upDirection;
    // Start is called before the first frame update
    void Start()
    {
        color = new Color(0.0f, 0.0f, 0.0f);
        gameObject.GetComponent<Renderer>().material.color = color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public virtual void DisplayText() 
    {
        Debug.Log("Undetermined Shape");
    }

    void SetColor()
    {
        color = new Color(12, 26, 34);
    }

    //Abstraction and polymorphism
    protected virtual void Move()
    {
        if (transform.position.y > 4)
        {
            upDirection = false;
        }
        else if (transform.position.y < -3)
        {
            upDirection = true;
        }
        if (upDirection)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.03f, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.03f, transform.position.z);
        }

    }
}

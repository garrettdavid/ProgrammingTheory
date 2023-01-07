using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cube : Shape
{
    // ENCAPSULATION
    public Color color { get; private set; } = Color.blue;
    public string shapeName { get; private set; }

    void Start()
    {
        shapeName = gameObject.name;
        gameObject.GetComponent<MeshRenderer>().material.color = color;
    }

    // ABSTRACTION
    void OnMouseDown() {
        DisplayText();
    }

    // POLYMORPHISM
    public override void DisplayText()
    {
        shapeDisplayText.text = "Blue " + shapeName;
    }
}

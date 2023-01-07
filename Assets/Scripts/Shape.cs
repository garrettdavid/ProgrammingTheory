using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shape : MonoBehaviour
{
    public TextMeshProUGUI shapeDisplayText;

    // Start is called before the first frame update
    void Start()
    {
        shapeDisplayText = FindObjectOfType<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void DisplayText() {
        shapeDisplayText.text = "Hello World";
    }
}

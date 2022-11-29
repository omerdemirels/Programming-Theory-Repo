using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Character
{
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        chracterType = "Cube";
        chracterMaterial = GetComponent<Material>();
        chracterColor = new Color32(166,0,0,255);
        colorName = "Red";
    }

    public override string DisplayText()
    {
        string chracterText = "You clicked a " + colorName + " " + chracterType;
        return chracterText;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Character
{
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        chracterType = "Cylinder";
        chracterMaterial = GetComponent<Material>();
        chracterColor = new Color(0, 0, 1, 1);
        colorName = "Blue";

    }

    public override string DisplayText()
    {
        string chracterText = "You clicked a " + colorName + " " + chracterType;
        return chracterText;
    }
}

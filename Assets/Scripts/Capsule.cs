using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Character
{
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        chracterType = "Capsule";
        chracterMaterial = GetComponent<Material>();
        chracterColor = new Color(0, 1, 0, 1);
        colorName = "Green";

    }

    // Update is called once per frame
    public override string DisplayText()
    {
        string chracterText = "You clicked a " + colorName + " " + chracterType;
        return chracterText;
    }
}

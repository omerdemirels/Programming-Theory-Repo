using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Character : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI chracterText;
    public TextMeshProUGUI playerNameText;

    public Rigidbody rb;
    
    protected string chracterType { get; set; }
    protected Material  chracterMaterial{ get; set; }
    protected Color chracterColor { get; set; }
    protected string colorName { get; set; }

    private float jumpForce = 5f;


    // Update is called once per frame
    void Update()
    {
        PrintChracter();
    }


    private void OnMouseDown()
    {
        Debug.Log("Clicked");
        chracterText.SetText(DisplayText());
        chracterText.color = chracterColor;
        Jump();
    }

    public virtual string DisplayText()
    {
        string chracterText = "Chracter Clicked";
        return chracterText;
    }
    private void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
    private void PrintChracter()
    {
        playerNameText.text = "Player: " + PlayerInfo.instance.playerName;
    }
}

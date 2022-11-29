using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuUI : MonoBehaviour
{
    // Start is called before the first frame update

    public TMP_InputField inputPlayerName;
    private string playerName;
    
    public void StartNewGame()
    {
        playerName = inputPlayerName.text;
        PlayerInfo.instance.playerName = playerName;
        SceneManager.LoadScene(1);
    }        
        }

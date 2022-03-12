using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Text ShowWinPlayer;
    public GameObject PlayagainBtn;
    public GameObject BackBtn;
    public GameObject WoodBG;

    void Start()
    {
        ShowWinPlayer.text = "";
        PlayagainBtn.SetActive(false);
        BackBtn.SetActive(false);
        WoodBG.SetActive(false);
    }


    void Update()
    {
        
    }
}

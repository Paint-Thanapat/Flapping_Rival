using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text ShowWinPlayer;
    public GameObject PlayagainBtn;
    public GameObject BackBtn;
    public GameObject WoodBG;

    public GameObject P1;
    public GameObject P2;
    public GameObject P3;
    public GameObject P4;

    public static GameController instance;

    public Camera Maincamera;

    public bool P1Dead = false;
    public bool P2Dead = false;
    public bool P3Dead = false;
    public bool P4Dead = false;

    public float P1Speed = 3;
    public float P2Speed = 3;
    public float P3Speed = 3;
    public float P4Speed = 3;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        } else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        ShowWinPlayer.text = "";
        PlayagainBtn.SetActive(false);
        BackBtn.SetActive(false);
        WoodBG.SetActive(false);
    }

    void Update()
    {
        if(P1Dead == false && P2Dead == true && P3Dead == true && P4Dead == true)
        {
            ShowWinPlayer.text = "Player 1 Win!!";
            PlayagainBtn.SetActive(true);
            BackBtn.SetActive(true);
            WoodBG.SetActive(true);
            ScrollingCamera.instance.MoveCam = 0;
            P2.SetActive(false);
            P3.SetActive(false);
            P4.SetActive(false);
        }

        if (P1Dead == true && P2Dead == false && P3Dead == true && P4Dead == true)
        {
            ShowWinPlayer.text = "Player 2 Win!!";
            PlayagainBtn.SetActive(true);
            BackBtn.SetActive(true);
            WoodBG.SetActive(true);
            ScrollingCamera.instance.MoveCam = 0;
            P1.SetActive(false);
            P3.SetActive(false);
            P4.SetActive(false);
        }

        if (P1Dead == true && P2Dead == true && P3Dead == false && P4Dead == true)
        {
            ShowWinPlayer.text = "Player 3 Win!!";
            PlayagainBtn.SetActive(true);
            BackBtn.SetActive(true);
            WoodBG.SetActive(true);
            ScrollingCamera.instance.MoveCam = 0;
            P1.SetActive(false);
            P2.SetActive(false);
            P4.SetActive(false);
        }

        if (P1Dead == true && P2Dead == true && P3Dead == true && P4Dead == false)
        {
            ShowWinPlayer.text = "Player 4 Win!!";
            PlayagainBtn.SetActive(true);
            BackBtn.SetActive(true);
            WoodBG.SetActive(true);
            ScrollingCamera.instance.MoveCam = 0;
            P1.SetActive(false);
            P2.SetActive(false);
            P3.SetActive(false);
        }
    }

    IEnumerator SpawnSpeedBoost()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);

        }
    }

    public void SpeedBoostP1()
    {
        P1Speed = 4.5f;
    }
    public void SpeedBoostP2()
    {
        P2Speed = 4.5f;
    }
    public void SpeedBoostP3()
    {
        P3Speed = 4.5f;
    }
    public void SpeedBoostP4()
    {
        P4Speed = 4.5f;
    } 
    public void SlowSpeedP1()
    {
        P1Speed = P1Speed - 1;
    }
    public void SlowSpeedP2()
    {
        P2Speed = P2Speed - 1;
    }
    public void SlowSpeedP3()
    {
        P2Speed = P3Speed - 1;
    }
    public void SlowSpeedP4()
    {
        P4Speed = P4Speed - 1;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnController : MonoBehaviour
{
    public GameObject PlayGameBtn;
    public GameObject HowtoPlayBtn;
    public GameObject ExitGameBtn;

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void PlayGameBotton()
    {
        SceneManager.LoadScene("SelectLevelScene");
    }

    public void HowtoPlayButton()
    {
        SceneManager.LoadScene("HowtoPlayScene");
    }

    public void ExitButton()
    {
        Application.Quit();
    }

    public void GotoMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void GotoPlayScene1()
    {
        SceneManager.LoadScene("PlayScene1");
    }
    public void GotoPlayScene2()
    {
        SceneManager.LoadScene("PlayScene2");
    }
}

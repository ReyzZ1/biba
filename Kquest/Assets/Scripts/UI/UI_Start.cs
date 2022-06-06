using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Start : MonoBehaviour
{
    // public Button btnStartNewGame;
    // public Button btnSettings;
    // public Button btnExit;


    public GameObject menuSettings;
    public GameObject menuStart;
    public GameObject menuConf;
    // public string menuCount;

    // public GameObject goSettings;

    public cross cross;

    public void StartNewGame(){
        //

        menuStart.SetActive(false);
    }


    public void ShowSettings(){

        menuStart.SetActive(false);

        cross.menuCount = "start";

        menuSettings.SetActive(true);
        
    }

    public void ShowConfirmation(){
        menuConf.SetActive(true);
    }

    public void ExitConfirm(){
        // exit the game

        menuStart.SetActive(false);
        menuConf.SetActive(false);
    }

    public void ExitCancel(){
        // hide confirmation and return to start menu

        menuConf.SetActive(false);
    }

    
}

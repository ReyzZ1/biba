using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Pause : MonoBehaviour
{

    public GameObject menuPause;
    public GameObject menuConf;
    public GameObject menuSettings;
    public GameObject menuStart;

    // public string menuCount;

    public cross cross;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            menuPause.SetActive(!menuPause.activeSelf);
        }
    }


    public void ContinueGame(){
        //

        menuPause.SetActive(false);
    }

    public void OpenMenuPause(){
        menuPause.SetActive(true);
    }

    public void ShowSettings(){

        menuPause.SetActive(false);

        cross.menuCount = "pause";

        menuSettings.SetActive(true);
    }

    public void Exit2Main(){
        menuPause.SetActive(false);
        menuStart.SetActive(true);
    }

    public void ExitConfirm(){
        // exit the game

        menuPause.SetActive(false);
        menuConf.SetActive(false);
    }

    public void ExitCancel(){
        // hide confirmation and return to start menu

        menuConf.SetActive(false);
    }

}

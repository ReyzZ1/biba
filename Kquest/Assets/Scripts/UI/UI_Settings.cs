using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Settings : MonoBehaviour
{

    public GameObject menuSettings;
    public GameObject menuStart;
    public GameObject menuConf;

    public GameObject menuPause;

    public cross cross;

    public void Back2Main(){
        if (cross.menuCount == "start"){
            print("sdl");
            menuSettings.SetActive(false);
            menuStart.SetActive(true);
            
        }

        if (cross.menuCount == "pause"){

            menuSettings.SetActive(false);
            menuPause.SetActive(true);

        }        
    }
}

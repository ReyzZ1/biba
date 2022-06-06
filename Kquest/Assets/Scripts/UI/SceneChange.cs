using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void ChangeScenes(int number){
        SceneManager.LoadScene(number);
    }

    public void Exit(){
        Application.Quit();
    }
}

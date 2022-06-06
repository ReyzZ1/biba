using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    public List<GameObject> dontDestroyObjects;
    // public GameObject player;
    private static GameObject instance;
    void Start() 
    {
        foreach(GameObject go in dontDestroyObjects){
            DontDestroyOnLoad(go);
        }
        // foreach(GameObject gameObject in dontDestroyObjects){
        //     DontDestroyOnLoad(gameObject);
        //     if (instance == null)
        //         instance = gameObject;
        //     else
        //         Destroy(gameObject);
        // }
        
    }
      
    // void Update()
    // {
    //     foreach(GameObject go in objects){
    //         if (GameObject.Find(go.name) != null){
    //             foreach(GameObject gameObj in objects){
    //             DontDestroyOnLoad(gameObj);          
    //             }                    
    //         }
    //         else{
    //             foreach(GameObject gameObj in objects){
    //                 Object.Destroy(gameObj);
    //             }
    //         }           
    //     }   
    // }
}
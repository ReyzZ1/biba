using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllyWithYou : MonoBehaviour
{
    public Main main;
    public List<GameObject> golist = new List<GameObject>();
    public GameObject player;
    public float speed;
 


    void Start()
    {
        main.pl.pce.onCollide += combine;
    }

    
    public void combine(GameObject go)
    {
        if(go.tag == "Ally")
        {
            golist.Add(go);
        }
        print("ally");
    }

    void Update()
    {
        foreach (GameObject go in golist)
        {
            go.transform.position = Vector3.MoveTowards(go.transform.position, player.transform.position, speed * Time.deltaTime);
        }
        //kquest Bogdan
    }
}

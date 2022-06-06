
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ally : MonoBehaviour
{
    public List<GameObject> Allies = new List<GameObject>();
    public GameObject Player;
    public float delay = 2f;
    public Vector3 velocity;
    public Vector3 offset;
    private float timer = 0;
    public List<Transform> AllySpawn = new List<Transform>();
    public GameObject ally;
    public float speed;
    public int ActAlly = 0;
    public Main main;
   


    void Start()
    {
        
        
    }


    void Update()
    {

        
        timer += Time.deltaTime;
        if (timer > 2f && Allies.Count < 10)
        {

            int number = Random.Range(0, 4);
            GameObject go = Instantiate(ally, AllySpawn[number].position, AllySpawn[0].rotation) as GameObject;
            Allies.Add(go);
            timer = 0;
            ActAlly++;
        }
        //kquest Bogdan

    }


}
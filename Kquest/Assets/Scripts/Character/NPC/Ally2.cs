using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ally2 : MonoBehaviour
{
    public List<GameObject> allies = new List<GameObject>();
    public GameObject Player;
    public float delay = 2f;
    public Vector3 velocity;
    public Vector3 offset;
    private float timer = 0;
    public List<Transform> AllySpawn = new List<Transform>();
    public GameObject ally;
    public GameObject ally2;
    public GameObject ally3;
    public GameObject ally4;
    public float speed;
    public int ActAlly = 0;
    public Main main;
    int number = 0;



    void Start()
    {


    }


    void Update()
    {


        timer += Time.deltaTime;
        if (timer > 2f && number < 4)
        {
            timer = 0;
            allies[number].gameObject.SetActive(true);
            number += 1;

        }
        //kquest Bogdan

    }


}

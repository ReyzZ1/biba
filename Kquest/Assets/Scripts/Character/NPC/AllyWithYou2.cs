using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllyWithYou2 : MonoBehaviour
{
    public Main main;
    public List<GameObject> golist = new List<GameObject>();
    public GameObject player;
    public float speed;
    public GameObject ally;
    public GameObject ally2;
    public GameObject ally3;
    public GameObject ally4;
    Animator animator;
    Animator animator2;
    Animator animator3;
    Animator animator4;
    Vector2 lastPos;
    Vector2 lastPos2;
    Vector2 lastPos3;
    Vector2 lastPos4;
    Vector2 currentPos;
    Vector2 currentPos2;
    Vector2 currentPos3;
    Vector2 currentPos4;
    float finPosx;
    float finPosy;
    float finPosx2;
    float finPosy2;
    float finPosx3;
    float finPosy3;
    float finPosx4;
    float finPosy4;
    int temp;
    int tempy;



    void Start()
    {
        main.pl.pce.onCollide += combine;
        animator = ally.GetComponent<Animator>();
        animator2 = ally2.GetComponent<Animator>();
        animator3 = ally3.GetComponent<Animator>();
        animator4 = ally4.GetComponent<Animator>();
    }


    public void combine(GameObject go)
    {
        if (go.tag == "Ally")
        {
            golist.Add(go);
        }
        print("ally");
    }

    void Update()
    {
        foreach (GameObject go in golist)
        {
            if (go.activeSelf)
            {
                go.transform.position = Vector3.MoveTowards(go.transform.position, player.transform.position, speed * Time.deltaTime);
            }
           
        }

        currentPos = ally.transform.position;
        currentPos2 = ally2.transform.position;
        currentPos3 = ally3.transform.position;
        currentPos4 = ally4.transform.position;

        finPosx = currentPos.x - lastPos.x;
        finPosy = currentPos.y - lastPos.y;
        finPosx2 = currentPos2.x - lastPos2.x;
        finPosy2 = currentPos2.y - lastPos2.y;
        finPosx3 = currentPos3.x - lastPos3.x;
        finPosy3 = currentPos3.y - lastPos3.y;
        finPosx4 = currentPos4.x - lastPos4.x;
        finPosy4 = currentPos4.y - lastPos4.y;

        lastPos = currentPos;
        lastPos2 = currentPos2;
        lastPos3 = currentPos3;
        lastPos4 = currentPos4;

        if (finPosx > 0 || finPosx2 > 0 || finPosx3 > 0 || finPosx4 > 0)
        {
            temp = 1;
        }
        if (finPosx < 0 || finPosx2 < 0 || finPosx3 < 0 || finPosx4 < 0)
        {
            temp = -1;
        }

        if (finPosy > 0 || finPosy2 > 0 || finPosy3 > 0 || finPosy4 > 0)
        {
            tempy = 1;
        }
        if (finPosy < 0 || finPosy2 < 0 || finPosy3 < 0 || finPosy4 < 0)
        {
            tempy = -1;
        }

        animator.SetFloat("Horizontal", temp);
        animator.SetFloat("Vertical", tempy);
        animator2.SetFloat("Horizontal", temp);
        animator2.SetFloat("Vertical", tempy);
        animator3.SetFloat("Horizontal", temp);
        animator3.SetFloat("Vertical", tempy);
        animator4.SetFloat("Horizontal", temp);
    }
}


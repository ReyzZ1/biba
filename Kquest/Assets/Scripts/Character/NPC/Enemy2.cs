using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy2 : MonoBehaviour
{
    public List<GameObject> enemies = new List<GameObject>();
    public GameObject Player;
    public float delay = 2f;
    public Vector3 velocity;
    public Vector3 offset;
    private float timer = 0;
    public List<Transform> spawners = new List<Transform>();
    public GameObject enemy;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    public GameObject enemy5;
    public GameObject enemy6;
    public GameObject enemy7;
    public GameObject enemy8;
    public GameObject enemy9;
    public GameObject enemy10;
    float speed = 3;
    Animator animator;
    Animator animator2;
    Animator animator3;
    Animator animator4;
    Animator animator5;
    Animator animator6;
    Animator animator7;
    Animator animator8;
    Animator animator9;
    Animator animator10;
    bool isMove = true;
    Vector2 lastPos;
    Vector2 lastPos2;
    Vector2 lastPos3;
    Vector2 lastPos4;
    Vector2 lastPos5;
    Vector2 lastPos6;
    Vector2 lastPos7;
    Vector2 lastPos8;
    Vector2 lastPos9;
    Vector2 lastPos10;
    Vector2 currentPos;
    Vector2 currentPos2;
    Vector2 currentPos3;
    Vector2 currentPos4;
    Vector2 currentPos5;
    Vector2 currentPos6;
    Vector2 currentPos7;
    Vector2 currentPos8;
    Vector2 currentPos9;
    Vector2 currentPos10;
    float finPosx;
    float finPosy;
    float finPosx2;
    float finPosy2;
    float finPosx3;
    float finPosy3;
    float finPosx4;
    float finPosy4;
    float finPosx5;
    float finPosy5;
    float finPosx6;
    float finPosy6;
    float finPosx7;
    float finPosy7;
    float finPosx8;
    float finPosy8;
    float finPosx9;
    float finPosy9;
    float finPosx10;
    float finPosy10;
    int temp;
    int tempy;
    public int number = 0;
    public int checker = 0;
 



    void Awake()
    {
        animator = enemy.GetComponent<Animator>();
        animator2 = enemy2.GetComponent<Animator>();
        animator3 = enemy3.GetComponent<Animator>();
        animator4 = enemy4.GetComponent<Animator>();
        animator5 = enemy5.GetComponent<Animator>();
        animator6 = enemy6.GetComponent<Animator>();
        animator7 = enemy7.GetComponent<Animator>();
        animator8 = enemy8.GetComponent<Animator>();
        animator9 = enemy9.GetComponent<Animator>();
        animator10 = enemy10.GetComponent<Animator>();
        print(enemies.Count);

    }


    void FixedUpdate()
    {

        //if (number <= 10)
        //{
           // number = 0;
        //}



        timer += Time.deltaTime;
        if (timer > 2f && number < 10)
        {
            timer = 0;
            enemies[number].gameObject.SetActive(true);
            number += 1;

        }

        


        if (timer > 3f)
        {
            foreach (GameObject go in enemies)
            {
                if (go.activeSelf)
                {
                    checker += 1;
                }
            }
            
            if (checker == 0)
            {
                print("You Win");
            }

        }



        foreach (GameObject enem in enemies)
        {

            if (enem.activeSelf)
            {
                enem.transform.position = Vector3.MoveTowards(enem.transform.position, Player.transform.position, speed * Time.deltaTime);

            }


        }


        currentPos = enemy.transform.position;
        currentPos2 = enemy2.transform.position;
        currentPos3 = enemy3.transform.position;
        currentPos4 = enemy4.transform.position;
        currentPos5 = enemy5.transform.position;
        currentPos6 = enemy6.transform.position;
        currentPos7 = enemy7.transform.position;
        currentPos8 = enemy8.transform.position;
        currentPos9 = enemy9.transform.position;
        currentPos10 = enemy10.transform.position;

        finPosx = currentPos.x - lastPos.x;
        finPosy = currentPos.y - lastPos.y;
        finPosx2 = currentPos2.x - lastPos2.x;
        finPosy2 = currentPos2.y - lastPos2.y;
        finPosx3 = currentPos3.x - lastPos3.x;
        finPosy3 = currentPos3.y - lastPos3.y;
        finPosx4 = currentPos4.x - lastPos4.x;
        finPosy4 = currentPos4.y - lastPos4.y;
        finPosx5 = currentPos5.x - lastPos5.x;
        finPosy5 = currentPos5.y - lastPos5.y;
        finPosx6 = currentPos6.x - lastPos6.x;
        finPosy6 = currentPos6.y - lastPos6.y;
        finPosx7 = currentPos7.x - lastPos7.x;
        finPosy7 = currentPos7.y - lastPos7.y;
        finPosx8 = currentPos8.x - lastPos8.x;
        finPosy8 = currentPos8.y - lastPos8.y;
        finPosx9 = currentPos9.x - lastPos9.x;
        finPosy9 = currentPos9.y - lastPos.y;
        finPosx10 = currentPos10.x - lastPos.x;
        finPosy10 = currentPos10.y - lastPos.y;


        lastPos = currentPos;
        lastPos2 = currentPos2;
        lastPos3 = currentPos3;
        lastPos4 = currentPos4;
        lastPos5 = currentPos5;
        lastPos6 = currentPos6;
        lastPos7 = currentPos7;
        lastPos8 = currentPos8;
        lastPos9 = currentPos9;
        lastPos10 = currentPos10;



        if (finPosx > 0 || finPosx2 > 0 || finPosx3 > 0 || finPosx4 > 0 || finPosx5 > 0 || finPosx6 > 0 || finPosx7 > 0 || finPosx8 > 0 || finPosx9 > 0 || finPosx10 > 0) 
        {
            temp = 1;
        }
        if (finPosx < 0 || finPosx2 < 0 || finPosx3 < 0 || finPosx4 < 0 || finPosx5 < 0 || finPosx6 < 0 || finPosx7 < 0 || finPosx8 < 0 || finPosx9 < 0 || finPosx10 < 0) 
        {
            temp = -1;
        }

        if (finPosy > 0 || finPosy2 > 0 || finPosy3 > 0 || finPosy4 > 0 || finPosy5 > 0 || finPosy6 > 0 || finPosy7 > 0 || finPosy8 > 0 || finPosy9 > 0 || finPosy10 > 0) 
        {
            tempy = 1;
        }
        if (finPosy < 0 || finPosy2 < 0 || finPosy3 < 0 || finPosy4 < 0 || finPosy5 < 0 || finPosy6 < 0 || finPosy7 < 0 || finPosy8 < 0 || finPosy9 < 0 || finPosy10 < 0) 
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
        animator4.SetFloat("Vertical", tempy);
        animator5.SetFloat("Horizontal", temp);
        animator5.SetFloat("Vertical", tempy);
        animator6.SetFloat("Horizontal", temp);
        animator6.SetFloat("Vertical", tempy);
        animator7.SetFloat("Horizontal", temp);
        animator7.SetFloat("Vertical", tempy);
        animator8.SetFloat("Horizontal", temp);
        animator8.SetFloat("Vertical", tempy);
        animator9.SetFloat("Horizontal", temp);
        animator9.SetFloat("Vertical", tempy);
        animator10.SetFloat("Horizontal", temp);
        animator10.SetFloat("Vertical", tempy);



    }
}


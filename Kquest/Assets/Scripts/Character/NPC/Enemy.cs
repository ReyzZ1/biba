using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public List<GameObject> enemies = new List<GameObject>();
    public GameObject Player;
    public float delay = 2f;
    public Vector3 velocity;
    public Vector3 offset;
    private float timer = 0;
    public List<Transform> spawners = new List<Transform>();
    public GameObject enemy;
    float speed = 3;
    int ActEnemy = 0;
    Animator animator;
    bool isMove = true;
    Vector2 lastPos;
    Vector2 currentPos;
    float finPosx;
    float finPosy;
    int temp;
    int tempy;



    void Awake()
    {
        animator = enemy.GetComponent<Animator>();
    }


    //void Awake()
    //{
        //lastPos = Player.transform.position; 
    //}
    
    void Update()
    {

        



        timer += Time.deltaTime;
        if(timer > 2f && enemies.Count < 10)
        {
            
            int number = Random.Range(0, 4);
            GameObject go = Instantiate(enemy, spawners[number].position, spawners[0].rotation) as GameObject;
            enemies.Add(go);
            timer = 0;
            ActEnemy++;
            enemy.gameObject.SetActive(true);


        }

        
        

        foreach (GameObject enem in enemies)
        {
            enem.transform.position = Vector3.MoveTowards(enem.transform.position, Player.transform.position, speed * Time.deltaTime);
            animator.SetFloat("Horizontal", temp);
            animator.SetFloat("Vertical", tempy);
            animator.SetBool("isMove", isMove);
        }


        currentPos = Player.transform.position;
        
        finPosx = currentPos.x - lastPos.x;
        finPosy = currentPos.y - lastPos.y;
        
        

        if (finPosx > 0)
        {
            temp = 1;
        }
        if (finPosx < 0)
        {
            temp = -1;
        }

        if (finPosy > 0)
        {
            tempy = 1;
        }
        if (finPosy < 0)
        {
            tempy = -1;
        }

        lastPos = currentPos;


    }
}

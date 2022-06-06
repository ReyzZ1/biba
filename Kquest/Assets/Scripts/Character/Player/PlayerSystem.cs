using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSystem : MonoBehaviour
{
    public PlayerCollisionEvent pce;
    public PlayerCollisionDetector pcd;
    public float hp;
    private float timer = 0;

    void Start()
    {
        hp = 100;
    }


    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 2f)
        {
            timer = 0;
            hp += 1;

        }
        
        if (hp > 100)
        {
            hp = 100;
        }
    }
}

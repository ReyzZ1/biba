using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGetDamage : MonoBehaviour
{
    public Main main;
    public GameObject Player;


    void Start()
    {
        main.pl.pce.onCollide += getdmg;
    }

    
    void Update()
    {
        
    }

    void getdmg(GameObject go)
    {
        if (go.tag == "Enemy")
        {
            print("owch");
            main.pl.hp -= 5;




        }
        
    }
}

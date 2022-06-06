using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horse : Object
{
    int hp;
    float speed;
    int stamina;

    public Horse(bool _is_pickable, int _hp, float _speed, int _stamina):base(_is_pickable){
        hp = _hp;
        speed = _speed;
        stamina = _stamina;
    }
}

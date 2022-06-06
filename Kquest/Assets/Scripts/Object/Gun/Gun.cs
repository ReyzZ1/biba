using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : Object
{
    int damage;
    float speed;
    float range;

    public Gun(bool _is_pickable, int _damage, float _speed, float _range):base(_is_pickable){
        damage = _damage;
        speed = _speed;
        range = _range;
    }
}

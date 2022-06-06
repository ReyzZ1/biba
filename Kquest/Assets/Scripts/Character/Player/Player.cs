using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : Character
{
    string name;
    bool isMale;
    int age;

    public Player(int _hp, float _speed, int _st, string _name, bool _isMale, int _age):base(_hp, _speed, _st){
        name = _name;        
        isMale = _isMale;
        age = _age;
    }  
}

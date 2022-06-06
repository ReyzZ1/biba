using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : Character
{
    int durability;

    public NPC(int _hp, float _speed, int _stamina, int _dur):base(_hp, _speed, _stamina){

        durability = _dur;
   }
}


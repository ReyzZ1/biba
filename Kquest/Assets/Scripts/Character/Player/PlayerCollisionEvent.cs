using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionEvent : MonoBehaviour
{
    public delegate void OnCollide(GameObject go);
    public event OnCollide onCollide;

    

    public string building;

    public void OnCollisionEnter2D(Collision2D other){
        print(other.gameObject);
        building = other.gameObject.name;
        onCollide?.Invoke(other.gameObject);
    }
}

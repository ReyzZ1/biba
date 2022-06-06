using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMoveEvent : MonoBehaviour
{
    public Main main;

    public delegate void OnMouseMove();
    public event OnMouseMove onMouseMoveEvent;

    void Update(){
        if(Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0){
            onMouseMoveEvent?.Invoke();
        }
    }
}

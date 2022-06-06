using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHandler : MonoBehaviour
{
    public Transform target;
    public float delay = 0.3f;
    private Vector3 velocity;  
    public Vector3 offset;

    void LateUpdate(){
        transform.position = Vector3.SmoothDamp(transform.position, target.position + offset, ref velocity, delay);
    }
}   

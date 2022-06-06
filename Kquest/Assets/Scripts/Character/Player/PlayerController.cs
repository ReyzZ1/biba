using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform trPlayer;
    public float speed;
    public Joystick joystick;
    public Rigidbody2D rb;
    public Animator animator;
    public Vector3 up = new Vector3(0f, 1f, 0f);
    public Vector3 down = new Vector3(0f, -1f, 0f);
    public Vector3 right = new Vector3(1f, 0f, 0f);
    public Vector3 left = new Vector3(-1f, 0f, 0f);
    public bool isMove;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
       
        if(Input.GetKey(KeyCode.W) || joystick.Vertical > 0.3f){
            trPlayer.position += up*speed*Time.deltaTime;
            isMove = true;
        }

        if (Input.GetKey(KeyCode.S) || joystick.Vertical < -0.3f){
            trPlayer.position += down*speed*Time.deltaTime;
            isMove = true;
        }
      


        if (Input.GetKey(KeyCode.A) || joystick.Horizontal < -0.3f){
            trPlayer.position += left*speed*Time.deltaTime;
            isMove = true;
        }
      

        if (Input.GetKey(KeyCode.D) || joystick.Horizontal > 0.3f){
            trPlayer.position += right*speed*Time.deltaTime;
            isMove = true;
        }
 
        
     
        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
        animator.SetFloat("Vertical", Input.GetAxis("Vertical"));
        animator.SetBool("isMove", isMove);

        


    }

    void Update()
    {
        
        isMove = false;

        if (Input.GetAxis("Horizontal") == -1 || Input.GetAxis("Horizontal") == 1 || Input.GetAxis("Vertical") == -1 || Input.GetAxis("Vertical") == 1)
        {
            animator.SetFloat("LastMoveX", Input.GetAxis("Horizontal"));
            animator.SetFloat("LastMoveY", Input.GetAxis("Vertical"));
        }
    }
}

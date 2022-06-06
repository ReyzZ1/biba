using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Animator animator;
    public Transform atkpoint;
    public Transform atkpointright;
    public float attackrange = 0.5f;
    public LayerMask Default;
    public int AttackDamage = 50;
    public float smoothTime = 10F;
    private Vector3 velocity = Vector3.zero;
    public Vector3 knockback = new Vector3(0.4f, 0f, 0f);


    void Start()
    {
        
    }

    void Attack()
    {
        
        float lastfloat = animator.GetFloat("Horizontal");
        if (lastfloat >= 0.1)
        {
            animator.SetTrigger("Attack");
            Collider2D[] hitenem = Physics2D.OverlapCircleAll(atkpointright.position, attackrange, Default);

            foreach (Collider2D enemy in hitenem)
            {

                if (enemy.tag == "Enemy")
                {
                    enemy.GetComponent<EnemHealth>().DamageTaken(AttackDamage);
                    enemy.transform.position = Vector3.SmoothDamp(enemy.transform.position, enemy.transform.position + knockback, ref velocity, smoothTime * Time.deltaTime);
                }



            }
        }
        else if (lastfloat <= -0.1)
        {
            animator.SetTrigger("Attack");
            Collider2D[] hitenem = Physics2D.OverlapCircleAll(atkpoint.position, attackrange, Default);

            foreach (Collider2D enemy in hitenem)
            {

                if (enemy.tag == "Enemy")
                {
                    enemy.GetComponent<EnemHealth>().DamageTaken(AttackDamage);
                    enemy.transform.position = Vector3.SmoothDamp(enemy.transform.position, enemy.transform.position - knockback, ref velocity, smoothTime * Time.deltaTime);
                }



            }
        }


    }
    
    
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Attack();
        }

    }

    void OnDrawGizmosSelected()
    {
        if(atkpoint == null)
        {
            return;
        }
        
        Gizmos.DrawWireSphere(atkpoint.position, attackrange);
        Gizmos.DrawWireSphere(atkpointright.position, attackrange);
    }
}

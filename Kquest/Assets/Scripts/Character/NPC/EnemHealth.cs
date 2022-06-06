using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemHealth : MonoBehaviour
{
    public int MaxHealth = 100;
    int currentHealth;
    public GameObject EnemySelf;
    

    void Start()
    {
        currentHealth = MaxHealth;
    }

    
    public void DamageTaken(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        EnemySelf.gameObject.SetActive(false);
        print("You killed him!");
    }
}

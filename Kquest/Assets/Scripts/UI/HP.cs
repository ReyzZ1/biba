using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    public Image Healthbar;
    public float CurrentHealth;
    public float MaxHealth = 100;
    public PlayerSystem chars;

    
    
    
    void Start()
    {
        Healthbar = GetComponent<Image>();
        chars = FindObjectOfType<PlayerSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        CurrentHealth = chars.hp;
        Healthbar.fillAmount = CurrentHealth / MaxHealth;
    }
    //kquest Bogdan
}

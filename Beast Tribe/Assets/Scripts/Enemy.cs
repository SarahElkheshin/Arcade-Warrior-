using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Enemy : MonoBehaviour
{
    private int hp = 100;
    public Slider healthBar; 
    public Animator animator;
    
    void Update ()
    {
        healthBar.value = hp;
    }
    
    public void TakeDamage(int damageAmount)
    {
        hp -= damageAmount;
        if(hp <= 0)
        {
            animator.SetTrigger("die");
            GetComponent<Collider>().enabled = false;
        }
        else
        {
            animator.SetTrigger("damage");
        }

    }
}

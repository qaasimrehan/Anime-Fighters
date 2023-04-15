using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItachiHealth : MonoBehaviour
{
     public int maxHealth = 100;
    private int currentHealth;
    public Animator animator;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        animator.SetTrigger("Itachi Heavy Damage");
    }
}
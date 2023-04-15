using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireHitbox : MonoBehaviour
{
    public int damage = 50;
    public string targetTag = "Naruto";
    public Animator animator;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(targetTag))
        {
            NarutoHealth health = other.GetComponent<NarutoHealth>();
            if (health != null)
            {
                health.TakeDamage(damage);
            }
            
            animator.SetTrigger("Naruto Heavy Damage");
        }
    }
}
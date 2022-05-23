using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public Animator animator;
    public int maxHealth = 100;
    int currentHealth;

    // Start is called before the first frame update
    public void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        animator.SetTrigger("Hurt"); //triggers hurt animation


        if (currentHealth <= 0)
        {
            Die();

        }
    }

    void Die()
    {
        Debug.Log("Enemy is dead!");
        animator.SetBool("IsDead", true);

        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;

    }
    // public void AnimCompleted() //called by timeline
    //{

    //  animator.SetBool("motion", false);

    //}

}

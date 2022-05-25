using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator animator;
    public int maxHealth = 100;
    int currentHealth;
    float deathTimer = 1f;
    public AudioSource deathSound;

    // Start is called before the first frame update
    public void Start()
    {
        currentHealth = maxHealth;   
    }

    private void Update()
    {
        if (currentHealth <= 0)
        {
            deathTimer -= Time.deltaTime;
        }
        if (deathTimer <= 0)
        {
            if (GameObject.FindGameObjectWithTag("endless"))
            {
                GameObject.FindGameObjectWithTag("endless").GetComponent<endlessManager>().enemyNum += 1;
            }
            
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        animator.SetTrigger("Hurt"); //triggers hurt animation


        if(currentHealth <= 0)
        {
            
            deathSound.Play();
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Enemy is dead!");
        animator.SetBool("IsDead", true);

        GetComponent<Collider2D>().enabled = false;
        GetComponent<EnemyAgro>().dead = true;

    }
}

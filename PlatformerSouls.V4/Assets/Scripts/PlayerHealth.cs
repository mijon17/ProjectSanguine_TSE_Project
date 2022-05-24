using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

	public int currentHealth = 100;
	public Animator animator;
	public int maxHealth = 100;
    public HealthBar healthBar;
	

	public void Start()
    {
		currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }


    public void TakeDamage(int damage)
	{
		currentHealth -= damage;

		animator.SetTrigger("Hurt");

        healthBar.SetHealth(currentHealth);



        if (currentHealth <= 0)
        {
            Die();
            Destroy(gameObject);
            SceneManager.LoadScene(2);
           
        }
    }

    void Die()
    {
        Debug.Log("Player has died!");
        animator.SetBool("IsDead", true);

        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;

    }

}
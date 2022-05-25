using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

	public int currentHealth = 500;
	public Animator animator;
	public int maxHealth = 500;
    public HealthBar healthBar;
    public healthCooldown cooldownSlider;
    float cooldown = 5f;
    bool healthUsed;
    public int healthGainNum = 10;
    public Text numText;
	

	public void Start()
    {
		currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        cooldownSlider.SetMaxCooldown(cooldown);
        numText.text = "Uses Left: " + healthGainNum.ToString();
    }

    public void Update()
    {
        if(cooldown >= 5f && Input.GetKeyDown(KeyCode.E) && healthGainNum > 0 && currentHealth < 500)
        {
            currentHealth += 100;
            animator.SetTrigger("healthGain");
            cooldown = 0f;
            healthUsed = true;
            cooldownSlider.SetCooldown(cooldown);
            healthBar.SetHealth(currentHealth);
            healthGainNum -= 1;
            numText.text = "Uses Left: " + healthGainNum.ToString();
        }
        else if (cooldown >= 5f)
        {
            healthUsed = false;
        }
        if (healthUsed)
        {
            cooldown += Time.deltaTime;
            cooldownSlider.SetCooldown(cooldown);
        }
        
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
           
        }
    }

    void Die()
    {
        Debug.Log("Player has died!");
        animator.SetBool("IsDead", true);

        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;
        SceneManager.LoadScene(2);

    }

}
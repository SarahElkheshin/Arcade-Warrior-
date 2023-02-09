using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
	public int maxHealth = 100;
	public int currentHealth;

	public HealthBar healthBar;
	public Animator playerAnimation;

	// Start is called before the first frame update
	void Start()
	{
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
		//playerAnimation = GetComponent<CharacterAnimations>();
	}
	/*void Update()
	{
		if (Input.GetKey(KeyCode.G))
		{
			TakeDamage(10);
		}
	}*/

	public void TakeDamage(int damage)
	{
		currentHealth -= damage;
		healthBar.SetHealth(currentHealth);

		if (currentHealth <= 0)
		{
			playerAnimation.SetTrigger("Die");

		}
		else
		{
			playerAnimation.SetTrigger("Hit");
		}

		
	}
}

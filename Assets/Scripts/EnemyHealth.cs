using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour, IDamageable {

	public int startingHealth = 3;
	public GameObject hitParticles;
	public int scoreValue = 10;


	private int currentHealth;

	void Start()
	{
		
		currentHealth = startingHealth;
	}

	public void Damage(int damage, Vector3 hitPoint)
	{
		Instantiate(hitParticles, hitPoint, Quaternion.identity);
		currentHealth -= damage;
		if (currentHealth <= 0) 
		{
			
			ScoreManager.score += scoreValue;
			Defeated();
		}
	}

	void Defeated()
	{
		Destroy (gameObject);
	}

}
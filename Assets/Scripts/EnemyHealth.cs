using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour, IDamageable {

	public Text scoreText;
	public int startingHealth = 3;
	public GameObject hitParticles;
	private int totalscore = 0;

	private int currentHealth;

	void Start()
	{
		scoreText.text = "Score: " + totalscore;
		currentHealth = startingHealth;
	}

	public void Damage(int damage, Vector3 hitPoint)
	{
		Instantiate(hitParticles, hitPoint, Quaternion.identity);
		currentHealth -= damage;
		if (currentHealth <= 0) 
		{
			totalscore += 10;
			scoreText.text = "Score: " + totalscore;
			Defeated();
		}
	}

	void Defeated()
	{
		gameObject.SetActive (false);
	}

}
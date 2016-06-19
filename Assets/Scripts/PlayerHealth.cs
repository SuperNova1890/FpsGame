using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

	public int TotalLifePoints = 100;
	public int LivePoints = 100;
	public int DamagePerHit = 10;

	public AudioClip hitSFX;

	AudioSource _audio;

	// Use this for initialization
	void Start ()
	{
		_audio = GetComponent<AudioSource> ();
		LivePoints = TotalLifePoints;

	}

	void OnTriggerEnter (Collider coll)
	{
		if (coll.gameObject.tag == "Enemy")
		{
			HandleHit ();
		}
	}

	void HandleHit ()
	{
		LivePoints -= DamagePerHit;
		_audio.PlayOneShot (hitSFX);


		GameObject.FindGameObjectWithTag ("pHealth").GetComponent<Image> ().fillAmount = 
				(float)LivePoints / TotalLifePoints;

		if (LivePoints <= 0)
			HandleDeath ();
	}

	void HandleDeath ()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
}

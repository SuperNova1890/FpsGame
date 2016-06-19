using UnityEngine;
using System.Collections;

public class FloorCheck: MonoBehaviour {

	public bool onGround = false;

	void OnTriggerEnter(Collider other) 
	{

		if (other.CompareTag ("Floor"))
		{
			onGround = true;	
		}
		else
		{
			onGround = false;
		}
	}

}

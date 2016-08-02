using UnityEngine;
using System.Collections;

public class Rocket : MonoBehaviour 
{
	void Start () 
	{
		// Destroy the rocket after 1.5 seconds if it doesn't get destroyed before then.
		Destroy(gameObject, 1.5f);
	}


	void OnExplode()
	{
		// Create a quaternion with a random rotation in the z-axis.
		Quaternion randomRotation = Quaternion.Euler(0f, 0f, Random.Range(0f, 360f));


	}
	

}

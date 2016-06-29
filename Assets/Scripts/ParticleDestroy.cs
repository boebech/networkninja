using UnityEngine;
using System.Collections;

public class ParticleDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//Destroy the particle System after 5 seconds...
		Destroy (gameObject, 5f);
	}
}

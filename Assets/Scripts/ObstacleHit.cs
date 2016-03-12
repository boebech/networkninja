using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ObstacleHit : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	


	void OnCollisionEnter2D(Collision2D other) {

		if (other.gameObject.CompareTag ("Player")) {
			
		}

	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathTrigger : MonoBehaviour {

	public static bool alive;

	// Use this for initialization
	void Start () {
		alive = true;
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag ("Player")) {
			alive = false;
		}
	}
		
}

using UnityEngine;
using System.Collections;

public class ReduceHealth : MonoBehaviour {

	[SerializeField] private int health = 100; 


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (health <= 0) {
			Destroy (gameObject);
			if (gameObject.CompareTag ("Player"))
				DeathTrigger.alive = false;
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (gameObject.CompareTag ("Player") && other.gameObject.CompareTag ("Bullet_Enemy")) {
			reduceHealth ();
			Destroy (other.gameObject);
		} else if (gameObject.CompareTag ("Enemy") && other.gameObject.CompareTag ("Bullet")) {
			reduceHealth ();
			Destroy (other.gameObject);
		} else if (gameObject.CompareTag ("Wall") && other.gameObject.CompareTag ("Bullet")) {
			reduceHealth ();
			Destroy (other.gameObject);
		} 
	}

	void OnCollisionEnter2D(Collision2D other) {
		if(gameObject.CompareTag("Player") && other.gameObject.CompareTag ("Bullet_Enemy")) {
			reduceHealth ();
			Destroy (other.gameObject);
		}
		if(gameObject.CompareTag("Enemy") && other.gameObject.CompareTag ("Bullet")) {
			reduceHealth ();
			Destroy (other.gameObject);
		} else if (gameObject.CompareTag ("Wall") && other.gameObject.CompareTag ("Bullet")) {
			reduceHealth ();
			Destroy (other.gameObject);
		} 		
	}

	private void reduceHealth() {
		health -= 34;
		Debug.Log ("Health reduced, new HP: " + health);
	}
}

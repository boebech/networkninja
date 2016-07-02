using UnityEngine;
using System.Collections;

public class ReduceHealth : MonoBehaviour {

	[SerializeField] private int health = 100; 
	public AudioClip playerHitSound;
	public GameObject healthParticle;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (health <= 0) {
			if (gameObject.CompareTag ("Player")) {
				if (ShowPlayerHealth.hp <= 0)
					DeathTrigger.alive = false;
			} else {
				Instantiate(healthParticle,transform.position,Quaternion.identity);
				Destroy (gameObject);
			} 

				
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (gameObject.CompareTag ("Player") && other.gameObject.CompareTag ("Bullet_Enemy")) {
			//Debug.Log ("Player Health reduced triggered");
			reduceHealth ();
			Destroy (other.gameObject);
		} else if (gameObject.CompareTag ("Enemy") && other.gameObject.CompareTag ("Bullet")) {
			Debug.Log ("Enemy Health reduced triggered");
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
		if (gameObject.CompareTag ("Player")) {
			reducePlayerHealth ();
		} else
			reduceOtherHealth ();
	}

	private void reducePlayerHealth() {
		health -= 20;
		ShowPlayerHealth.hp -= 20;
		AudioSource.PlayClipAtPoint(playerHitSound, transform.position);
	}

	private void reduceOtherHealth() {
		health -= 20;
		Debug.Log ("Health reduced: " + health);
	}
}

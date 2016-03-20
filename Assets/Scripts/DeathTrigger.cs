using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathTrigger : MonoBehaviour {

	private AudioSource source;
	public AudioClip spikeSound;
	public static bool alive;

	// Use this for initialization
	void Start () {
		alive = true;
	}

	void Update() {
		//if timerMode is Countdown and 0 is reached the player is killed manually and the game is ended
		if (GameTimer.getTimerMode() == 1 && GameTimer.getTimer() == 0) {
			killPlayer ();
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag ("Player")) {
			killPlayer ();
		}
	}

	void OnCollisionEnter2D(Collision2D other) {
		if (other.gameObject.CompareTag ("Player")) {
			killPlayer ();
			AudioSource.PlayClipAtPoint(spikeSound, transform.position); //source.clip = coinSound; source.Play(); not working?!
		}
	}

	private void killPlayer() {
		alive = false;
	}

		
}

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

	void Update() {
		//if timerMode is Countdown and 0 is reached the player is killed manually and the game is ended
		if (GameTimer.getTimerMode() == 1 && GameTimer.getTimer() == 0) {
			DeathTrigger.alive = false;
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag ("Player")) {
			alive = false;
		}
	}

	void OnCollisionEnter2D(Collider2D other) {
		if(other.gameObject.CompareTag("Player")) {
			alive = false;
		}
	}
		
}

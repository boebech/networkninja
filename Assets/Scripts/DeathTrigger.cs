using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathTrigger : MonoBehaviour {

	private AudioSource source;
	public AudioClip deathSound;
	public AudioClip fallingSound;
	public static bool alive;
	[SerializeField]
	private GameObject playerParticle;


	void Start () {
		alive = true;
	}

	void Update() {

		//In jedem Frame wird kontrolliert, ob der Countdown abgelaufen ist
		if (GameTimer.getTimerMode() == 1 && GameTimer.getTimer() == 0) {
			killPlayer ();
		}
	}

	//Diese Funktion tötet den Spieler in Leveln, in denen man Fallen kann
	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag ("Player")) {
			killPlayer ();
			AudioSource.PlayClipAtPoint(fallingSound, transform.position);

		}
	}

	//Diese Funktion tötet den Spieler, wenn er mit anderen Objekten/Gegnern in Berührung kommt
	void OnCollisionEnter2D(Collision2D other) {
		if (other.gameObject.CompareTag ("Player")) {
			killPlayer ();
			AudioSource.PlayClipAtPoint(deathSound, transform.position); //source.clip = coinSound; source.Play(); not working?!

		}
	}

	private void killPlayer() {
		alive = false;
	}

		
}

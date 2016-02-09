using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

	private AudioSource source;
	public AudioClip coinSound;

	void Awake () {
		source = GetComponent<AudioSource> ();
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag ("Player")) {
			CoinCount.coinCount ++;
			AudioSource.PlayClipAtPoint(coinSound, transform.position); //source.clip = coinSound; source.Play(); not working?!
			Destroy (gameObject);
		}
	}

}

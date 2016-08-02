using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

	private AudioSource source;
	public AudioClip coinSound;

	[SerializeField]
	private GameObject pickupPrefab;

	void Awake () {
		source = GetComponent<AudioSource> ();
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag ("Player")) {

			//Das Partikelsystem wird erzeugt
			Instantiate(pickupPrefab,transform.position,Quaternion.identity);

			//Der Highscore wird hochgezählt und es ertönt ein Geräusch
			CoinCount.coinCount ++;
			AudioSource.PlayClipAtPoint(coinSound, Camera.main.transform.position, 0.25f); 

			Destroy (gameObject);
		}
	}

}

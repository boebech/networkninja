﻿using UnityEngine;
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
			Instantiate(pickupPrefab,transform.position,Quaternion.identity);
			CoinCount.coinCount ++;
			AudioSource.PlayClipAtPoint(coinSound, Camera.main.transform.position, 0.25f); 

			Destroy (gameObject);
		}
	}

}

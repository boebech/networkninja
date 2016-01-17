using UnityEngine;
using System.Collections;

public class SpawnCoins : MonoBehaviour {

	public Transform[] coinspawns;
	public GameObject coin;

	// Use this for initialization
	void Start () {
		Spawn ();
	}

	void Spawn() {
		for(int i = 0; i < coinspawns.Length; i++) {
			int coinFlip = Random.Range (0, 2); // max wird nicht beachtet, also entweder 0 oder 1
			if(coinFlip > 0) {
				Instantiate(coin, coinspawns[i].position, Quaternion.identity);
			}

		}
	}
}

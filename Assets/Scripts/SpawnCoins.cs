using UnityEngine;
using System.Collections;

public class SpawnCoins : MonoBehaviour {

	public Transform[] coinspawns;
	public GameObject coin;

	void Start () {
		Spawn ();
	}

	void Spawn() {
		for(int i = 0; i < coinspawns.Length; i++) {
			int coinFlip = Random.Range (0, 2); 
			if(coinFlip > 0) {
				Instantiate(coin, coinspawns[i].position, Quaternion.identity);
			}

		}
	}
}

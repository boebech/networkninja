using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CoinCount : MonoBehaviour {

	public static int coinCount;
	public Text countText;


	void Start() {
		coinCount = 0;
	}

	void Update() {
		countText.text = "Coins: " + coinCount;
	}


}

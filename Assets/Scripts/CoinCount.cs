using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CoinCount : MonoBehaviour {

	public static int coinCount = 0;
	public Text countText;


	void Start() {
		//coinCount = 0; //reset coincount with each new start of a level
	}

	void Update() {
		countText.text = "" + coinCount;
	}


}

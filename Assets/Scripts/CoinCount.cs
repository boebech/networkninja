using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CoinCount : MonoBehaviour {

	public static int coinCount = 0;
	public Text countText;


	void Start() {
		if(SceneManager.GetActiveScene().name.Equals("scene2")) {
			countText.color = Color.white;
		} else
			countText.color = Color.black;
		//coinCount = 0; //reset coincount with each new start of a level
	}

	void Update() {
		countText.text = "" + coinCount;
	}


}

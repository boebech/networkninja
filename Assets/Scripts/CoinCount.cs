using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CoinCount : MonoBehaviour {

	public static int coinCount = 0;
	public Text countText;


	void Start() {

		//Aufgrund der unterschiedlichen Hintergrundfarben (weiß und schwarz) muss die Textfarbe sich an die Level anpassen
		if(SceneManager.GetActiveScene().name.Equals("scene2")) {
			countText.color = Color.white;
		} else
			countText.color = Color.black;
	}

	void Update() {

		//Workaround, da die ToString Methode nicht funktioniert
		countText.text = "" + coinCount;
	}


}

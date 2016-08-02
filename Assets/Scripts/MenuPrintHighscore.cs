using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuPrintHighscore : MonoBehaviour {

	public Text highscore;


	void Start () {
		highscore.text = "NETWORKNINJA (SCORE: " + PlayerPrefs.GetInt ("CoinCount", 0) + ")";
	}
		
}

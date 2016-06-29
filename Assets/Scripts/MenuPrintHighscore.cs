using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuPrintHighscore : MonoBehaviour {

	public Text highscore;

	// Use this for initialization
	void Start () {
		highscore.text = "NETWORKNINJA (SCORE: " + PlayerPrefs.GetInt ("CoinCount", 0) + ")";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

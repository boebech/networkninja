using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour {

	//check if the transferred value is higher than the saved PlayerPref
	public static bool isHighScore(int count) {
		PlayerPrefs.DeleteAll (); //reset highscore for testing purposes, usually commented out!

		if (count > PlayerPrefs.GetInt ("CoinCount", 0)) {
			return true;
		}
		else {
			return false;
		}
	}

	// save the transferred value as the new high score in the PlayerPref 
	public static void saveHighScore(int count) {
		//int time = (int) timeRemaining;
		//int score = count + time;
		PlayerPrefs.SetInt("CoinCount", count);
	}
}

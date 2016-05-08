using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishTrigger : MonoBehaviour {

	public static bool finish;
	[SerializeField] private Text gameStateText;

	// Use this for initialization
	void Start () {
		finish = false;
	}

	void OnCollisionEnter2D(Collision2D other) {

		if (other.gameObject.CompareTag ("Player")) {
			switch(SceneManager.GetActiveScene ().name) {
			case "scene0":
				setLevelPrefs (0);
				SceneManager.LoadScene ("scene1");
				break;
			case "scene1":
				setLevelPrefs (1);
				SceneManager.LoadScene ("scene2");
				break;
			case "scene2":
				setLevelPrefs (2);
				finish = true;
				break;
			default:
				Debug.Log ("default");
				break;
			}
		}

	}

	//save the highest level the player achieved (e.g. for display in the start menu)
	void setLevelPrefs(int recentlyFinishedLevel) {
		int highestLevelAchieved = PlayerPrefs.GetInt("LevelAchieved", 0);
		if (recentlyFinishedLevel > highestLevelAchieved)
			PlayerPrefs.SetInt ("LevelAchieved", recentlyFinishedLevel);
	}

}
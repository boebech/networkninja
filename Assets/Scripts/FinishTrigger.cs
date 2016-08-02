using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishTrigger : MonoBehaviour {

	public static bool finish;
	[SerializeField] private Text gameStateText;


	void Start () {
		finish = false;
	}

	void OnCollisionEnter2D(Collision2D other) {

		if (other.gameObject.CompareTag ("Player")) {
			switch(SceneManager.GetActiveScene ().name) {
			case "scene1":
				setLevelPrefs (2);
				SceneManager.LoadScene ("scene2");
				break;
			case "scene2":
				setLevelPrefs (3);
				SceneManager.LoadScene ("scene3");
				break;
			case "scene3":
				//setLevelPrefs (4);
				finish = true;
				break;
			default:
				break;
			}
		}

	}

	//das höchste jemals vom Spieler erreichte Level wird gespeichert, sodass es beim Menü angezeigt werden kann
	void setLevelPrefs(int recentlyFinishedLevel) {
		int highestLevelAchieved = PlayerPrefs.GetInt("LevelAchieved", 0);
		if (recentlyFinishedLevel > highestLevelAchieved)
			PlayerPrefs.SetInt ("LevelAchieved", recentlyFinishedLevel);
	}

}
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishTrigger : MonoBehaviour {

	public static bool finish;

	// Use this for initialization
	void Start () {
		finish = false;
	}

	void OnCollisionEnter2D(Collision2D other) {

		if (other.gameObject.CompareTag ("Player")) {
			switch(Application.loadedLevelName) {
			case "scene0":
				SceneManager.LoadScene ("scene1");
				break;
			case "scene1":
				finish = true;
				Debug.Log ("GameFinished");
				break;
			default:
				Debug.Log ("default");
				break;
			}
		}

	}
		
}
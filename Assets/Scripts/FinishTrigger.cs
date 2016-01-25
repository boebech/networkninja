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

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag ("Player")) {
			finish = true;
			Debug.Log ("GameFinished");
		}
	}
}
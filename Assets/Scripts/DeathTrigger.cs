using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathTrigger : MonoBehaviour {

	public Text gameOverText;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag ("Player")) {
			//SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
			Debug.Log("Game over!\nYou lost.");
			gameOverText.text = "Game over!\nYou lost.";
		}
	}
}

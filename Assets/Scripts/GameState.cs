using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour {


	public bool gameStarted = false;
	[SerializeField]
	private Text gameStateText;
	private float restartDelay = 3f;
	private float restartTimer;
	private int i = 0; // count value to ensure that EndGame() is called only once

	void Update () {

		if(gameStarted == false && Input.GetKeyUp(KeyCode.Space)){
			StartGame();
		}

		if(DeathTrigger.alive == false || FinishTrigger.finish == true){
			if (i == 0) EndGame ();
			i++;

			// increment a timer to count up to restarting
			restartTimer = restartTimer + Time.deltaTime;

			if(restartTimer >= restartDelay){

				//reset counter so that EndGame() can be called again
				i = 0; 

				//...reload the menu scene loaded level.
				SceneManager.LoadScene("menuscene");

			}
		}
			
	}

	private void StartGame(){

		gameStarted = true;
		Cursor.visible = false;


	}

	// called only once to make sure the highscore is displayed properly
	private void EndGame(){
		string endText = "";

		Cursor.visible = true;

		gameStarted = false;
		if (FinishTrigger.finish == true)
			endText = "Congrats!\nYou won.";
		else
			endText = "Game over!\nYou lost.";

		if (ScoreManager.isHighScore (CoinCount.coinCount)) {
			endText = endText + "\nNew Highscore: " + CoinCount.coinCount;
			ScoreManager.saveHighScore (CoinCount.coinCount);
		}
		CoinCount.coinCount = 0; // Coin Zähler zurücksetzen, entweder wenn der Spieler stirbt oder das Spiel beendet

		//end currently playing track since it will overlap with the menu-music 
		GameObject[] destroyable = GameObject.FindGameObjectsWithTag ("destroyable");
		foreach(GameObject go in destroyable) {
			Destroy (go);
		}

		PrintGameStateText (endText);

	}


	public void PrintGameStateText(string endText) {
		gameStateText.text = endText;
		if(SceneManager.GetActiveScene().name.Equals("scene2")) {
			gameStateText.color = Color.white;
		} else
			gameStateText.color = Color.black;
	}
		

}
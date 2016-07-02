using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour {


	public bool gameStarted = false;
	[SerializeField]
	private Text gameStateText;
//	[SerializeField]
//	private GameObject player;
//	[SerializeField]
//	private BirdMovement birdMovement;
//	[SerializeField]
//	private FollowCamera followCamera;
	private float restartDelay = 3f;
	private float restartTimer;
//	private PlayerMovement playerMovement;
//	private PlayerHealth playerHealth;
	private int i = 0; // count value to ensure that EndGame() is called only once

	// Use this for initialization
	void Start () {


//		playerMovement = player.GetComponent<PlayerMovement> ();
//		playerHealth = player.GetComponent<PlayerHealth> ();

		// Prevent the player from moving at the start of the game
//		playerMovement.enabled = false;

		// Prevent the bird from moving at the start of the game
//		birdMovement.enabled = false;

		// Prevent the camera from moving at the start of the game
//		followCamera.enabled = false;
	}

	// Update is called once per frame
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



		//Cursor.visible = false;

		gameStarted = true;


//		playerMovement.enabled = true;

//		birdMovement.enabled = true;

//		followCamera.enabled = true;


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
		CoinCount.coinCount = 0; // reset counter (either after player died or finshed the game)

		//end currently playing track since it will overlap with the menu-music 
		GameObject[] destroyable = GameObject.FindGameObjectsWithTag ("destroyable");
		foreach(GameObject go in destroyable) {
			Destroy (go);
		}

		PrintGameStateText (endText);

		//Time.timeScale = 0.0f; //freeze entire game (including update functions)

//		player.SetActive (false);
	}


	public void PrintGameStateText(string endText) {
		gameStateText.text = endText;
		if(SceneManager.GetActiveScene().name.Equals("scene2")) {
			gameStateText.color = Color.white;
		} else
			gameStateText.color = Color.black;
	}
		

}
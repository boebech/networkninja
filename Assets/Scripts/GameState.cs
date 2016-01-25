using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour {


	private bool gameStarted = false;
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
			EndGame();

			// increment a timer to count up to restarting
			restartTimer = restartTimer + Time.deltaTime;

			if(restartTimer >= restartDelay){

				//...reload the currently loaded level.
				SceneManager.LoadScene("scene0");


			}
		}

	}

	private void StartGame(){



		Cursor.visible = false;

		gameStarted = true;

		gameStateText.color = Color.clear;

//		playerMovement.enabled = true;

//		birdMovement.enabled = true;

//		followCamera.enabled = true;


	}

	private void EndGame(){

		Cursor.visible = true;

		gameStarted = false;

		gameStateText.text = "Game over!\nYou lost.";
		gameStateText.color = Color.white;

//		player.SetActive (false);
	}

}
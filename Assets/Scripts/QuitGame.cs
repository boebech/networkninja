﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class QuitGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("escape")) {

			Cursor.visible = true;

			switch(SceneManager.GetActiveScene().name) {
			case "menuScene":
				Debug.Log ("Quit");
				Application.Quit();
				break;
			default:
				SceneManager.LoadScene ("menuScene");
				break;
			}
		}
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetLevelVisibility : MonoBehaviour {

	//public Renderer rend;
	public Text levelText;


	void Start() {
		//rend = GetComponent<Renderer> ();

		int highestLevelAchieved = PlayerPrefs.GetInt("LevelAchieved", 0);
		if (levelText.text.Equals("Level 2")) {
			Debug.Log (highestLevelAchieved);
			if (highestLevelAchieved < 2)
				levelText.text = " ";
		} 
		if (levelText.text.Equals("Level 3")) {
			//if (highestLevelAchieved < 3) rend.enabled = false;
		} //usw...

		
	}
		
}

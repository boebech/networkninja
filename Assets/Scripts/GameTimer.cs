using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameTimer : MonoBehaviour {

	private static int timerMode = 1; // 0=elapsed time, 1=countdown
	private static float timer;
	private static bool timeStarted = false;

	public Text timerText;
	private float timerDuration = 100f;

	// Use this for initialization
	void Start () {
		setTimerDuration ();
		if (timerMode == 1)
			timer = timerDuration;
		else
			timer = 0;
		timeStarted = true;
	}

	// Update is called once per frame
	void Update () {
		if (timeStarted) {
			if (timerMode == 0)
				timer += Time.deltaTime;
			if (timerMode == 1) {
				timer -= Time.deltaTime;
				if (timer <= 0)
					timer = 0;
			}
				
			updateGUI ();
		}
	}

	void updateGUI() {
		int minutes = Mathf.FloorToInt(timer / 60F);
		int seconds = Mathf.FloorToInt(timer - minutes * 60);
		string timeFormat = string.Format("{0:00}:{1:00}", minutes, seconds);

		timerText.text = timeFormat;
	}

	public static float getTimer() {
		return timer;
	}

	public static float getTimerMode() {
		return timerMode;
	}

	private void setTimerDuration() {
		if (Application.loadedLevelName.Equals("scene1"))
			timerDuration = 30f;
		if (Application.loadedLevelName.Equals("scene2"))
			timerDuration = 60f;
	}
		
}

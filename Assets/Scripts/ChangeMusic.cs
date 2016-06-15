using UnityEngine;
using System.Collections;

public class ChangeMusic : MonoBehaviour {

	private AudioSource source;
	public AudioClip level1Music;
	public AudioClip level2Music;
	public static bool wasRunningBefore = false;

	// Use this for initialization
	void Awake () {
		source = GetComponent<AudioSource> ();
		if (AudioManager.isBackgroundMusicPlaying) {
			//Debug.Log ("source is playing");
		} else {
			//Debug.Log ("source was not playing. start now...");
			source.Play();
			AudioManager.isBackgroundMusicPlaying = true;
		}
			
	}

	void OnLevelWasLoaded (int level){
		if(level == 1 /*&& wasRunningBefore==false*/){
			source.clip = level1Music;
			source.Play ();
			AudioManager.isBackgroundMusicPlaying = false;
			//wasRunningBefore=true;
		}
		if(level == 2 /*&& wasRunningBefore==false*/){
			source.clip = level2Music;
			source.Play ();
			AudioManager.isBackgroundMusicPlaying = false;
			//wasRunningBefore=true;
		}
	}
}

using UnityEngine;
using System.Collections;

public class ChangeMusic : MonoBehaviour {

	private AudioSource source;
	public AudioClip level1Music;
	public static bool wasRunningBefore = false;

	// Use this for initialization
	void Awake () {
		source = GetComponent<AudioSource> ();
	}

	void OnLevelWasLoaded (int level){
		if(level == 1 && wasRunningBefore==false){
			source.clip = level1Music;
			source.Play ();
			wasRunningBefore=true;
		}
	}
}

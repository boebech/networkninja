using UnityEngine;
using System.Collections;

public class ChangeMusic : MonoBehaviour {

	private AudioSource source;
	public AudioClip menuMusic;
	public AudioClip level1Music;
	public AudioClip level2Music;

	void Awake () {
		source = GetComponent<AudioSource> ();

		//wenn bereits Hintergrundmusik läuft
		if (AudioManager.isBackgroundMusicPlaying) {
			//passiert nichts	
		} else {
			//ansonsten wird die Musik gestartet
			source.Play();
			AudioManager.isBackgroundMusicPlaying = true;
		}
			
	}

	void OnLevelWasLoaded (int level){
		if(level == 0){ //level0 = menu
			source.clip = menuMusic;
			source.Play ();

			//Musik vom aktuellen Level wird beim Sterben abgeschaltet und muss deshalb beim nächsten mal neu gestartet werden
			AudioManager.isBackgroundMusicPlaying = false;

		}
		if(level == 1 ){
			source.clip = level1Music;
			source.Play ();

			//Musik vom aktuellen Level wird beim Sterben abgeschaltet und muss deshalb beim nächsten mal neu gestartet werden
			AudioManager.isBackgroundMusicPlaying = false;
		
		}
		if(level == 2 ){
			source.clip = level2Music;
			source.Play ();

			//Musik vom aktuellen Level wird beim Sterben abgeschaltet und muss deshalb beim nächsten mal neu gestartet werden
			AudioManager.isBackgroundMusicPlaying = false;

		}
		if(level == 3 ){
			source.clip = level1Music;
			source.Play ();

			//Musik vom aktuellen Level wird beim Sterben abgeschaltet und muss deshalb beim nächsten mal neu gestartet werden
			AudioManager.isBackgroundMusicPlaying = false;

		}
	}
}

using UnityEngine;
using System.Collections;

public class IncreaseHealth : MonoBehaviour {

	private AudioSource source;
	public AudioClip clip;

	void Awake() {
		source = GetComponent<AudioSource> ();
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log ("Triggered");
		if(gameObject.CompareTag("Player") && other.gameObject.CompareTag("Heart")) {
			if (ShowPlayerHealth.hp < 100) {
				increaseHealth ();
				Destroy (other.gameObject);
			} else
				Debug.Log ("HP full!");
		} else Debug.Log("GO=" + gameObject.tag + " other " + other.gameObject.tag);
	}

	private void increaseHealth() {
		AudioSource.PlayClipAtPoint (clip, transform.position);
		ShowPlayerHealth.hp += 20;
	}
}

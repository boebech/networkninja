using UnityEngine;
using System.Collections;

public class IncreaseHealth : MonoBehaviour {

	private AudioSource source;
	public AudioClip clip;

	public GameObject healthParticle;

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
				Instantiate(healthParticle,transform.position,Quaternion.identity);
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

using UnityEngine;
using System.Collections;

public class SetVisible : MonoBehaviour {

	//script attached to a platform
	public Renderer rend;

	//platform will be invisible at game start
	void Start() {
		rend = GetComponent<Renderer> ();
		rend.enabled = false;
	}

	//when the player enters the platform it will become visible
	void OnCollisionEnter2D(Collision2D other) {
		if (other.gameObject.CompareTag ("Player")) {
			rend.enabled = true;
		}
	}
}

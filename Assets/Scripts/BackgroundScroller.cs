using UnityEngine;
using System.Collections;

public class BackgroundScroller : MonoBehaviour {

	public float speed = 0;

	void Update () {
		moveBackgroundImage ();
	}

	public void moveBackgroundImage() {
		GetComponent<Renderer>().material.mainTextureOffset = new Vector2 ((Time.time * speed) % 1, 0f);
	}
}

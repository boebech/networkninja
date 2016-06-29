using UnityEngine;
using System.Collections;

public class BackgroundScroller : MonoBehaviour {

	public float speed = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		moveScreen ();
	}

	public void moveScreen() {
		GetComponent<Renderer>().material.mainTextureOffset = new Vector2 ((Time.time * speed) % 1, 0f);
	}
}

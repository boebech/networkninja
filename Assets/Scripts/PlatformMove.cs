using UnityEngine;
using System.Collections;

public class PlatformMove : MonoBehaviour {

	private Rigidbody2D platformRigidbody;
	public float platformSpeed = 0.2f;
	private Vector2 initialPlatformPos = new Vector2 (0,0);
	private Vector2 platformPos = new Vector2 (0, 0);
	private float upOrDown = 1;
	public float intervall = 6;

	// Use this for initialization
	void Start () {
		platformRigidbody = GetComponent<Rigidbody2D> ();
		platformPos = platformRigidbody.position;
		initialPlatformPos = platformRigidbody.position;
	}

	// Update is called once per frame

	void Update () 
	{
		if (platformRigidbody.position.y > initialPlatformPos.y + (intervall/2)) {
			upOrDown = -1;
		}
		if (platformRigidbody.position.y < initialPlatformPos.y - (intervall/2)) {
			upOrDown = 1;
		}
		//float xPos = platformRigidbody.position.x + (Input.GetAxis("Horizontal") * playerSpeed);
		float yPos = platformRigidbody.position.y + (0.2f * platformSpeed * upOrDown);
		platformPos = new Vector2 (platformRigidbody.position.x,yPos);
		platformRigidbody.position = platformPos;

	}
}
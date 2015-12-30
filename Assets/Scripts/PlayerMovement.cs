using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	private Rigidbody playerRigidbody;
	public float playerSpeed = 0.25f;
	private Vector3 playerPos = new Vector3 (0, 0, 0);

	// Use this for initialization
	void Start () {
		playerRigidbody = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame

	void Update () 
	{
		float xPos = playerRigidbody.position.x + (Input.GetAxis("Horizontal") * playerSpeed);
		float zPos = playerRigidbody.position.z + (Input.GetAxis ("Vertical") * playerSpeed);
		playerPos = new Vector3 (Mathf.Clamp (xPos, -8f, 8f), 0f, Mathf.Clamp(zPos,-8f,8f));
		playerRigidbody.position = playerPos;

	}

}

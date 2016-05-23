using UnityEngine;
using System.Collections;

public class FollowCamera : MonoBehaviour {

	[SerializeField]
	private Transform player;
	[SerializeField]
	private Vector3 offset;
	private float cameraFollowSpeed = 5f;

	private float restartDelay = 5f;
	private float restartTimer;
	
	// Update is called once per frame
	void Update () {
		Vector3 newPosition = player.position + offset;

		//transform.position = Vector3.Lerp (transform.position, newPosition, cameraFollowSpeed * Time.deltaTime);
		transform.position = newPosition;


		// increment a timer to count up to switching angle
		restartTimer = restartTimer + Time.deltaTime;

		if(restartTimer >= restartDelay){

			//reset counter so that EndGame() can be called again
			offset.z = offset.z - 7;
			restartTimer = 0f;

		}
	
	}
}

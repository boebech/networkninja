using UnityEngine;
using System.Collections;

public class FollowCamera : MonoBehaviour {

	[SerializeField]
	private Transform player;
	[SerializeField]
	private Vector3 offset;
	private float cameraFollowSpeed = 5f;

	private float restartDelay = 0.08f;
	private float restartTimer;
	

	void Update () {
		Vector3 newPosition = player.position + offset;

		//damit könnte eine verzögerte Kamerabewegung realisiert werden
		//transform.position = Vector3.Lerp (transform.position, newPosition, cameraFollowSpeed * Time.deltaTime);
		transform.position = newPosition;



		restartTimer = restartTimer + Time.deltaTime;

		if(restartTimer >= restartDelay){


			//offset.z = offset.z - 0.02f;
			//offset.x = offset.x - 0.03f;
			//transform.RotateAround(player.position,new Vector3(0,1,0,50);

			restartTimer = 0f;

		}
	
	}
}

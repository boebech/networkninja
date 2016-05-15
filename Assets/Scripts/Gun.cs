using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour
{
	public Rigidbody2D rocket;				// Prefab of the rocket.
	public float speed = 20f;				// The speed the rocket will fire at.


	private PlatformController playerCtrl;		// Reference to the PlayerControl script.
	private Animator anim;					// Reference to the Animator component.

	private AudioSource source;
	public AudioClip gunshot;


	void Awake()
	{
		// Setting up the references.
		anim = transform.root.gameObject.GetComponent<Animator>();
		playerCtrl = transform.root.GetComponent<PlatformController>();
	}


	void Update ()
	{

		if (transform.tag == "Player") {
			// If the fire button is pressed...
			if (Input.GetButtonDown ("Fire1")) {
				// ... set the animator Shoot trigger parameter and play the audioclip.
				anim.SetTrigger ("Shoot");
				AudioSource.PlayClipAtPoint (gunshot, transform.position); 


				// If the player is facing right...
				if (playerCtrl.facingRight) {
					// ... instantiate the rocket facing right and set it's velocity to the right. 
					Rigidbody2D bulletInstance = Instantiate (rocket, transform.position, Quaternion.Euler (new Vector3 (0, 0, 0))) as Rigidbody2D;
					bulletInstance.velocity = new Vector2 (speed, 0);
				} else {
					// Otherwise instantiate the rocket facing left and set it's velocity to the left.
					Rigidbody2D bulletInstance = Instantiate (rocket, transform.position, Quaternion.Euler (new Vector3 (0, 0, 180f))) as Rigidbody2D;
					bulletInstance.velocity = new Vector2 (-speed, 0);
				}
			}

		}

		if (transform.tag == "Enemy") {

			int shootAtRandom = Random.Range (0, 150); 
			int randomShotDirection = Random.Range (0, 2); //0=right, 1=left
			float rocketFacingDirection = 0; //0 = right, 180f = left
			float rocketFlyingDirection = speed; // separated variable that is reinitialized with every update call

			// 0.66% chance that enemy fires for each frame
			if (shootAtRandom == 0) {
				// set the animator Shoot trigger parameter and play the audioclip.
				anim.SetTrigger ("Shoot");
				AudioSource.PlayClipAtPoint (gunshot, transform.position); 


				Vector3 rocketLaunch = transform.position + new Vector3 (2, 2, 0);

				//if shot direction is determined as 1 (left) speed is inversed and rocket sprite is turned
				if (randomShotDirection == 1) {
					rocketFlyingDirection = -speed;
					rocketFacingDirection = 180f;
				} 

				Rigidbody2D bulletinstance = Instantiate (rocket, rocketLaunch, Quaternion.Euler (new Vector3 (0, 0, rocketFacingDirection))) as Rigidbody2D;
				bulletinstance.velocity = new Vector2 (rocketFlyingDirection, 0);

			}

		}
	}
}

 using UnityEngine;
using System.Collections;

public class PlatformController : MonoBehaviour {

	[HideInInspector] public bool facingRight = true;
	[HideInInspector] public bool jump = false;

	public float moveForce = 365f;
	public float maxSpeed = 5f;
	public float jumpForce = 1000f;
	public Transform groundCheck;

	private bool grounded = false;
	private Animator anim;
	private Rigidbody2D rb2d;

	public GameObject playerParticle;
	private bool particlesCreated = false;


	void Awake () {
		anim = GetComponent<Animator> ();
		rb2d = GetComponent<Rigidbody2D>();
	}
	

	void Update () {
		grounded = Physics2D.Linecast (transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));

		if (grounded)
			anim.SetTrigger ("Grounded");
		else
			anim.SetTrigger ("Jumping");

		if(Input.GetButtonDown("Jump") && grounded) {
			jump = true;
		}
	}

	void FixedUpdate() {
		if (DeathTrigger.alive) { 
			float h = Input.GetAxis ("Horizontal");

			anim.SetFloat ("Speed", Mathf.Abs (h));

			if (h * rb2d.velocity.x < maxSpeed)
				rb2d.AddForce (Vector2.right * h * moveForce); // es wird nur right benutzt, aber wenn h negativ wird dies automatisch zu left

			if (Mathf.Abs (rb2d.velocity.x) > maxSpeed)
				rb2d.velocity = new Vector2 (Mathf.Sign (rb2d.velocity.x) * maxSpeed, rb2d.velocity.y);

			if (h > 0 && !facingRight)
				Flip ();
			else if (h < 0 && facingRight)
				Flip ();

			if (jump) {

				Vector2 jumpVector = new Vector2(0f, jumpForce);
				rb2d.AddForce (jumpVector);
				jump = false;
			}
		} 
		else {
			if (!particlesCreated) {
				Instantiate(playerParticle,transform.position,Quaternion.identity);
				particlesCreated = true;
				Destroy (gameObject);
			}


		}
	}

	void Flip() {
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}


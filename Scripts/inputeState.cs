using UnityEngine;
using System.Collections;

public class inputState : MonoBehaviour {

	public bool actionButton;
	public float absVelX = 0f;
	public float absVelY = 0f;
	public bool standing;
	public float standingThreshold = 1;

	private Rigidbody body2d;

	void Awake(){
		body2d = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		actionButton = Input.GetButtonDown ("Jump");
	}

	void FixedUpdate(){
		absVelX = System.Math.Abs (body2d.velocity.x);
		absVelY = System.Math.Abs (body2d.velocity.y);


	}

	void OnTriggerEnter( Collider col)
	{
		standing = true;
	}

}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class jump : MonoBehaviour {

	public float jumpSpeed = 240f;
	public float forwardSpeed = 20;

	private Rigidbody body2d;
	//private inputState inputState;

	public bool ground = true;



	//public bool actionButton;
	public float absVelX = 0f;
	public float absVelY = 0f;
	public bool standing;
	public float standingThreshold = 1;




	void Awake() {
		body2d = GetComponent <Rigidbody> ();
		//rb = GetComponent<Rigidbody>();
		//inputState = GetComponent <inputState> ();
	}


	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Jump") && ground) {
			
			Debug.Log ("jump");
		//	ground = false;
		//	if(!ground)
			body2d.AddForce(transform.up * jumpSpeed);

			Debug.Log(ground);

		}
	}

	void FixedUpdate(){
		absVelX = System.Math.Abs (body2d.velocity.x);
		absVelY = System.Math.Abs (body2d.velocity.y);

		standing = absVelY <= standingThreshold;
	}



}

using UnityEngine;
using System.Collections;

public class RootMotionControl : MonoBehaviour {

    private Animator anim;

	void Start () {
        anim = GetComponent<Animator>();
	}
	
	void Update () {
		anim.SetFloat ("vert", Input.GetAxis ("Vertical"), 0.2f, Time.deltaTime);
		anim.SetFloat ("hori", Input.GetAxis ("Horizontal"), 0.2f, Time.deltaTime);


    }
}

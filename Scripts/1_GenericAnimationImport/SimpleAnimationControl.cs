using UnityEngine;
using System.Collections;

public class SimpleAnimationControl : MonoBehaviour
{
	private Animator anim;

    void Start()
    {
		anim = GetComponent<Animator> ();
    }

    void Update()
    {
		anim.SetBool ("Walking", Input.GetMouseButton (0));
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class death : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Player") {
			SceneManager.LoadScene ("run");
		}
		if (col.gameObject.transform.parent) {
			Destroy (col.gameObject.transform.parent.gameObject);
		} 
		else {
			Destroy (col.gameObject);
		}
	}

}

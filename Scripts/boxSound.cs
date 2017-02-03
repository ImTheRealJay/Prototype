using UnityEngine;
using System.Collections;

public class boxSound : MonoBehaviour {

	public AudioClip impact;
	AudioSource audio;



	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource>();
	
	}
	
	// Update is called once per frame
	void Update () {
		//audio.pitch += Time.deltaTime;

	}

	void OnTriggerEnter(Collider collision)
	{
		Debug.Log ("hit");

		audio.PlayOneShot(impact, 0.7F);
	

	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {
	public AudioClip soundDeath;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider Other) {
		if (Other.gameObject.tag == "Player"){
			GetComponent<AudioSource>().PlayOneShot(soundDeath);
			Other.gameObject.transform.position = GameObject.Find("SpawnPoint").transform.position;
		}
	}
}

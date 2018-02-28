using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisionTourniquet : MonoBehaviour {

	public AudioClip soundDeath;
	private Vector3 spawnPoint;
	// Use this for initialization
	void Start () {
		spawnPoint = GameObject.Find("SpawnPoint").GetComponent<Transform>().position;
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider Other) {
		if (Other.gameObject.tag=="Player"){
			GetComponent<AudioSource>().PlayOneShot(soundDeath);
			Other.gameObject.transform.position = spawnPoint;
		}
	}
}

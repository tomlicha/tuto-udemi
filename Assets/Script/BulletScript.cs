using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log("player dead");
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider Other) {
		if (Other.gameObject.tag == "Player"){
			Other.gameObject.transform.position = GameObject.Find("SpawnPoint").transform.position;
		}
	}
}

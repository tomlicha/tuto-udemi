using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boat : MonoBehaviour {

	// Use this for initialization
void OnTriggerEnter (Collider Other) {
		if (Other.gameObject.tag == "Player"){
			Other.transform.SetParent(this.transform);
		}
	}
	
	// Update is called once per frame
void OnTriggerExit (Collider Other) {
		if (Other.gameObject.tag == "Player"){
			Other.transform.parent=null;
		}
	}
}

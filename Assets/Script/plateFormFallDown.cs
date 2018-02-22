using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plateFormFallDown : MonoBehaviour {

	//variables
	public float secToFall = 2;
	private Rigidbody rb;
	private Material plateFormeFallDown;
	private Vector3 positionDepart;
	Material plateformColor;
	

	// Use this for initialization
	void Start () {
		rb = GetComponent <Rigidbody> ();
		positionDepart = transform.position;
		plateformColor = GetComponent<Renderer>().material;
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider Other) {
		if(Other.gameObject.tag == "Player"){
			plateformColor.color = Color.red;
			StartCoroutine(FallDown());
		}
		if (Other.gameObject.tag == "ZoneSpwan"){
			plateformColor.color = Color.white;
			rb.isKinematic = true;
			transform.position=positionDepart;
		}
	}
	IEnumerator FallDown (){
		yield return new WaitForSeconds(secToFall);
		rb.isKinematic=false;
	}
}

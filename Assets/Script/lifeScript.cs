using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class lifeScript : MonoBehaviour {

	public float nblife = 3;
	public Text txtLife;
	void Start () {
		txtLife.text = "Lives : "+nblife;
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider Other) {
		if (Other.gameObject.tag == "Player"){
			nblife-=0.5f;
			if (nblife<=0){
			
				SceneManager.LoadScene("Gameover");
			
			}
			else{

				txtLife.text = "Lives : "+(int)nblife;
		
			}}
	}
}

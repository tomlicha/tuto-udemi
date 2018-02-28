using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	public float timeBeforeMenu = 5;
	// Use this for initialization
	void Start () {
		StartCoroutine(LoadMenu());
	}
	
	// Update is called once per frame
	IEnumerator LoadMenu(){
		yield return new WaitForSeconds(timeBeforeMenu);
		SceneManager.LoadScene("menu");
	}
}

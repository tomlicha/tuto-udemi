using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endLevel : MonoBehaviour {

	public string levelToLoad;
	public AudioClip soundWin;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider Other) {
		if (Other.gameObject.tag == "Player"){
			StartCoroutine(loadNextLevel());
		}
	}

	IEnumerator loadNextLevel (){
		GetComponent<AudioSource>().PlayOneShot(soundWin);
		yield return new WaitForSeconds(3);
		SceneManager.LoadScene(levelToLoad);
	}
}

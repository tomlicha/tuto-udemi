﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	public void Exit(){
		Debug.Log("exit");
		Application.Quit();
	}
	public void Play(){
		SceneManager.LoadScene("scene1");
	}
}

﻿using UnityEngine;
//using System.Collections;

public class GamePlayManager : MonoBehaviour {

	void Start () {
		Events.GameOverEvent += GameOver;
	}
	
	private void GameOver(){
		//Debug.Log("over in manager");
		// show gameover dialog
	}

	void OnDisable(){
		Events.GameOverEvent -= GameOver;
	}
}

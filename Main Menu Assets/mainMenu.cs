/*
Initial Author: Jaret Miller
This is the code for the main menu.
If changes are made, COMMENT what you did and your name|initials.
*/

using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
using UnityEngine.SceneManagement; 


public class MainMenu: MonoBehaviour {  
	public void PlayGame() { //Starts the game.
		SceneManager.LoadScene("gameScene");  
	}
	public void exitMenu(){ //Exits the game.
		Debug.Log("QUIT");
		SceneManager.LoadScene("exitMenu");
	}
	public void devMode(){ //Launches Developer mode for testing features/functions.
		SceneManager.LoadScene("devMode");
	}
	public void settingsMenu(){ //Opens Settings menu.
		SceneManager.LoadScene("settingsMenu");
	}
}  
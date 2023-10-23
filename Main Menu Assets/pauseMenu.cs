/*
Initial Author: Jaret Miller
This will be a part of the pause menu.
If changes are made, COMMENT what you did and your name|initials.
*/

using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
using UnityEngine.SceneManagement; 
 
public class pauseMenu: MonoBehaviour {  
	public void mainMenu(){ //Opens main menu.
		SceneManager.LoadScene("mainMenu");
	}
	public void exitMenu(){ //Opens the exit confirmation manu.
		SceneManager.LoadScene("exitMenu");
	}
	public void exitConfirm(){ //Used to confim exit
		Application.Quit();
		
	}
}  
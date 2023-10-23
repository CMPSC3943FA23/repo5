/*
Initial Author: Jaret Miller
This is the code for the settings menu.
If changes are made, COMMENT what you did and your name|initials.
*/

using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
using UnityEngine.SceneManagement; 
 
public class settingsMenu: MonoBehaviour {  
	public void mainMenu(){ //Opens main menu.
		SceneManager.LoadScene("mainMenu");
	}
}  
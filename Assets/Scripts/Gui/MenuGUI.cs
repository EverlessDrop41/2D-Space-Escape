using UnityEngine;
using System.Collections;

public class MenuGUI : MonoBehaviour {

	public string GameSceneName = "GamePlay";
	public string OptionsSceneName;

	void OnGUI () {
		//Game Title
		GUI.Label(new Rect (Screen.width/2 - 40,Screen.height/2 - 80,100,50), "Space Escape");
		//Play Button
		if (GUI.Button(new Rect(Screen.width/2 - 50,Screen.height/2 -25,100,50),"Play")) {
			Application.LoadLevel(GameSceneName);
		}
		//Options Button
		if (GUI.Button(new Rect(Screen.width/2 - 50, Screen.height/2 + 50,100,50),"Options")) {
			Debug.Log("MAKE AN OPTIONS MENU YOU STUPID DEV");
		}
		//Exit Button
		if (GUI.Button(new Rect(Screen.width/2 - 50, Screen.height/2 + 125,100,50),"Quit")) {
			Application.Quit();
		}
	}
}

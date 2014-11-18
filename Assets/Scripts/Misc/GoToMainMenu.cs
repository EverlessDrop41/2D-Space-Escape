using UnityEngine;
using System.Collections;

public class GoToMainMenu : MonoBehaviour {

	public KeyCode escape = KeyCode.Escape;

	void Awake(){
		DontDestroyOnLoad(gameObject);
	}

	void Update() {
		if (Input.GetKey(escape)) {
			Application.LoadLevel("Menu");
		}
	}
}

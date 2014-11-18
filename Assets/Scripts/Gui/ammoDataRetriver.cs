using UnityEngine;
using System.Collections;

[RequireComponent(typeof(GUIText))]
public class ammoDataRetriver : MonoBehaviour {

	public string message;
	public string playerPrefsName;

	void Start() 
	{
		//Disable on android
		#if UNITY_ANDROID
			this.gameObject.SetActive(false);
		#endif
	}

	void Update () {
		if (PlayerPrefs.GetString("gunType") == "laser"){
			gameObject.SetActive(false);
		}
		else if (PlayerPrefs.GetString("gunType") == "gun"){
			gameObject.SetActive(true);
		}

		gameObject.guiText.text = message + PlayerPrefs.GetString(playerPrefsName);
	}
}

using UnityEngine;
using System.Collections;

public class ScoreSetter : MonoBehaviour {

	void Update () {
		PlayerPrefs.SetFloat("Score",gameObject.transform.position.x);
		//HighScore
		if (gameObject.transform.position.x > PlayerPrefs.GetFloat("HighScore")) {
			PlayerPrefs.SetFloat("HighScore",gameObject.transform.position.x);
		}
	}
}

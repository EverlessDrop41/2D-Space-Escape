using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HighScoreDisplayer : MonoBehaviour {

	public Text HS;

	void Update()
	{
		HS.text = "Highscore: " + PlayerPrefs.GetFloat("HighScore").ToString("F1");
	}
}

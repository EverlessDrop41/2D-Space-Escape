using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreDisplayer : MonoBehaviour {

    public Text Score;
    public Text HighScore;

	void Update() {
		if (Score != null) 
		{
			Score.text = "Score:" + PlayerPrefs.GetFloat("Score").ToString("F1");
		}

		if (HighScore != null) 
		{
			HighScore.text = "High Score"+ System.Environment.NewLine + "       " + PlayerPrefs.GetFloat("HighScore").ToString("F1");
		}
	}
}

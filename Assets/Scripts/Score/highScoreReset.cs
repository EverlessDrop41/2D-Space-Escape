using UnityEngine;
using System.Collections;

public class highScoreReset : MonoBehaviour {

	public void OnMouseDown() {
		PlayerPrefs.DeleteAll();
	}
}

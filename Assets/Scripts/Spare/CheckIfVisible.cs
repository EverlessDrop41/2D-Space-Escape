using UnityEngine;
using System.Collections;

public class CheckIfVisible : MonoBehaviour {

	private int VisibleChance;
	public int TotalVisibleChances = 5;
	public bool DestroyObj;
	public bool restartLevel;

	// Update is called once per frame
	void LateUpdate () {
		//Determine if the object is visible by the camera
		if (renderer.isVisible) {
			Debug.Log(gameObject + " is Visible");
		}
		else {
			Debug.Log(gameObject + " isn't visible");
			VisibleChance += 1;
		}

		//If visible chances have run out
		if (VisibleChance >= TotalVisibleChances) {
			if (restartLevel) {
				Application.LoadLevel(Application.loadedLevel);
			}
			if (DestroyObj) {
				Destroy(gameObject);
			}
		}
	}
}

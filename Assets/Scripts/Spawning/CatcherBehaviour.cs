using UnityEngine;
using System.Collections;

public class CatcherBehaviour : MonoBehaviour {

	public bool DestroyObj;
	public bool restartLevel;
	public string levelToLoadIfHitTag;
	public string hitTag;
	public bool debuglog;
	
	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.gameObject.tag != "Catcher") {
			//If Destroy object is true, destroy the object
			if (DestroyObj) {
				GameObject.Destroy(coll.gameObject);
				if (debuglog) {
					Debug.Log("Destroyed" + coll.gameObject);
				}
			}
			//If restart level is true restart the level
			if (restartLevel) {
				Application.LoadLevel(Application.loadedLevel);
			}
			//If the collisions tag is equal to the users defined tag 
			//restart the level
			if (coll.gameObject.tag == hitTag) {
				Application.LoadLevel(levelToLoadIfHitTag);
			}
		}
	}
}

using UnityEngine;
using System.Collections;

public class heatDisplayer : MonoBehaviour {

	public Texture[] logos;
	public laserGun laser;
	public Rect size;

	private float heat;
	private Texture logo;

	void Start() {
		#if UNITY_ANDROID
				Destroy(this);
		#endif
		size.y = Screen.height - size.height - size.y;
	}

	void Update(){
		heat = laser.currentHeat;

		if (heat > 4) {
			logo = logos[4];
		}
		else if (heat > 3) {
			logo = logos[3];
		}
		else if (heat > 2) {
			logo = logos[2];
		}
		else if (heat > 1) {
			logo = logos[1];
		}
		else if (heat >= 0) {
			logo = logos[0];
		}
		else {
			Debug.LogError("No logo found");
		}
	}

	void OnGUI(){
		GUI.DrawTexture(size,logo,ScaleMode.ScaleToFit,true);
	}
}

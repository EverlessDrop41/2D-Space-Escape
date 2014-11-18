using UnityEngine;
using System.Collections;

public class heatBar : MonoBehaviour {
	
	public Texture2D barBackground;
	public Texture2D barProgress;
	public Vector2 barPos;
	public Vector2 barSize;
	public laserGun laser;

	static float progress;

	void Start() {
	}

	void Update() {
		//Obtain the heat
		progress = laser.currentHeat;
		//turn heat into percentage
		progress = progress * 0.05f;
	}

	void OnGui() {
		//draw the background:
		GUI.BeginGroup(new Rect(barPos.x, barPos.y, barSize.x, barSize.y));
			GUI.Box(new Rect(0,0, barSize.x, barSize.y), barBackground);
			
			//draw the filled-in part:
			GUI.BeginGroup(new Rect(0,0, barSize.x * progress, barSize.y));
				GUI.Box(new Rect(0,0, barSize.x, barSize.y), barProgress);
			GUI.EndGroup();
		GUI.EndGroup();
	}
}

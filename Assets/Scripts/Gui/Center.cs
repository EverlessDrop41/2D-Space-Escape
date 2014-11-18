using UnityEngine;
using System.Collections;

public class Center : MonoBehaviour {

	public bool x;
	public bool y;
	public bool isGUItext;
	public GUIText GuiText;

	private float posx;
	private float posy;

	void Update () {
		if (isGUItext) {
			//Set text anchor to the center
			GuiText.anchor = TextAnchor.UpperCenter;
			//Get x position
			if (x) {
				posx = Screen.width/2;
			}
			else{
				posx = GuiText.pixelOffset.x;
			}
			//Get y positon
			if (y) {
				posy = Screen.height/2;
			}
			else {
				posy = GuiText.pixelOffset.y;
			}
			//Center
			GuiText.pixelOffset = new Vector2 (posx,posy);
		}
		else {
			//Get x Position
			if (x) {
				posx = Screen.width/2;
			}
			else {
				posx = gameObject.transform.position.x;
			}
			//Get Y position
			if (y) {
				posy = Screen.height/2;
			}
			else{
				posy = gameObject.transform.position.y;
			}
			//Center
			gameObject.transform.position = new Vector3(posx,posy);
		}

	}


}

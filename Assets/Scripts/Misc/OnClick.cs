using UnityEngine;
using System.Collections;

public class OnClick : MonoBehaviour {

	public string shipname;

	void BeginGame(string ship) {
		PlayerPrefs.SetString("ShipChoice",ship);

		Application.LoadLevel("GamePlay");
	}

}

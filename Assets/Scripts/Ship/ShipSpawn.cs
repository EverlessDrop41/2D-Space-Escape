using UnityEngine;
using System.Collections;

public class ShipSpawn : MonoBehaviour {

	static string ship;
	public GameObject[] ships;
	private int i;

	void Start () {
		ship = PlayerPrefs.GetString("ShipChoice");

		for (int i = 0; i < ships.Length ; i++) {
			if (ships[i].name == ship) {
				Instantiate(ships[i]);
				break;
			}	
		}

	}
}

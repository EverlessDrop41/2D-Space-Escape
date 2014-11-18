using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public bool Use;
	private GameObject obj;
	private int objNum;
	public float spawnInterval;
	public float minSpawnInterval = 1.0f;
	public float maxSpawnInterval = 2.0f;
	public GameObject[] spawnItems;

	void Start() {
		if (Use) {
			spawn ();
		}
	}
	
	void spawn() {
		//Overide The spawn interval if it's negative or equal to nothing
		if (spawnInterval <= 0) {
			spawnInterval = Random.Range(minSpawnInterval,maxSpawnInterval);
		}
		//Choose a numner for the game object
		objNum = Random.Range(0, spawnItems.Length);
		//Match the number to a game object
		obj = spawnItems[objNum];
		//Create the object
		Instantiate(obj,transform.position,Quaternion.identity);
		Invoke("spawn",spawnInterval);
	}
}

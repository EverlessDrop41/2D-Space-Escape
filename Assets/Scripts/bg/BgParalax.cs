using UnityEngine;
using System.Collections;

public class BgParalax : MonoBehaviour {

	public float speed = 7;

	void Update () {
		gameObject.transform.position += new Vector3 (speed,0,0) * Time.deltaTime;
	}
}

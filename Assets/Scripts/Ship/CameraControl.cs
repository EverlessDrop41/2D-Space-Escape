using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

	public float speed = 5;

	void Update () {
		transform.position += new Vector3(speed,0,0) * Time.deltaTime;
	}
}

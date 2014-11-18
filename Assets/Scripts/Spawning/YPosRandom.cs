using UnityEngine;
using System.Collections;

public class YPosRandom : MonoBehaviour {

	public float maxPos = 1;
	public float minPos = -1;
	private float pos;
	public bool debuglog = true;
	// Use this for initialization
	void Start () {
		pos = Random.Range(minPos,maxPos);
		if (debuglog) {
			Debug.Log(pos);
		}
		transform.position = new Vector3(transform.position.x,pos,transform.position.z);
	}
}

using UnityEngine;
using System.Collections;

public class BgController : MonoBehaviour {

	public Vector3 size = new Vector3(76.8f,0f,0f);

	// Use this for initialization
	void OnCollisionEnter(Collision hit) {
		if (hit.gameObject.tag == "bg") {
			hit.transform.position += size;
		}
	}
}

using UnityEngine;
using System.Collections;

public class MissisleBehaviour : MonoBehaviour {

	public float speed;
	public float explosionRadius;

	void OnCollisionEnter2D(Collision2D hit) {
		Destroy(hit.gameObject);
	}
	void Update() {
		gameObject.transform.position += new Vector3(speed,0,0) * Time.deltaTime;
	}


}

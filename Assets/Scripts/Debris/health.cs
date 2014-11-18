using UnityEngine;
using System.Collections;

public class health : MonoBehaviour {

	public float maxHealth;
	public float minHealth;
	public float currentHeath;

	void Start() {
		currentHeath = maxHealth;
	}

	void Update() {
		if (currentHeath < minHealth) {
			Destroy(transform.gameObject);
		}
	}

	public void takeDamage(float Damage) {
		currentHeath = currentHeath - Damage;
	}

}

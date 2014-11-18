using UnityEngine;
using System.Collections;

public class ShipGun : MonoBehaviour {

	public GameObject missile;
	public GameObject ammoPickup;
	public int ammoPickupAmount;
	public int maxAmmo;
	public int startingAmmo;
	public bool useAmmo;
	public float XOffset;
	public float YOffset;
	public float ZOffset;

	public Rect AndroidFireButton;


	//Private Variables
	private bool canShoot;
	private int currentAmmo;

	void Start() {
		//Set the ammo to be the starting ammo
		currentAmmo = startingAmmo;
		//Tell game the gun type is a gun
		PlayerPrefs.SetString("gunType","gun");
	}

	void Update () {
		//Actually Fire
		if (Input.GetButtonDown("Fire") && canShoot) {
			//Create the bullet
			Instantiate(missile,new Vector3(gameObject.transform.position.x + XOffset,gameObject.transform.position.y + YOffset,gameObject.transform.position.z + ZOffset),Quaternion.identity);
			//Reduce the ammo
			currentAmmo -= 1;
			Debug.Log("Fired");	
		}

		//Ammo Controll
		if (useAmmo) {
			//Check if there's ammo
			if (currentAmmo <= 0) {
				//stop shooting from occuring
				canShoot = false;
			}
			else {
				canShoot = true;
			}
		}
		else {
			canShoot = true;
		}

		//Display Ammo
		PlayerPrefs.SetString("Ammo",currentAmmo.ToString());	
	}

	void OnCollisionEnter2D(Collision2D coll) {
		//Pickup Ammo
		if (coll.gameObject.tag == "Ammo Pickup") {
			currentAmmo = currentAmmo + ammoPickupAmount;
			Destroy(coll.gameObject);
		}

	}
}

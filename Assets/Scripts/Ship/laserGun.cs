using UnityEngine;
using System.Collections;

public class laserGun : MonoBehaviour {

	public Transform laserPos;
	public LineRenderer laserVisual;
	public float laserDistance;
	public float costPerSecond;
	public float laserWidth;
	public float laserDamage;
	public string laserHeatMessage;
	public float maxHeat;
	public float coolRate;
	public float coolDelay;

	public float currentHeat;
	private bool canShoot;



	void Start() {
		canShoot = true;
		currentHeat = 0;
		PlayerPrefs.SetString("gunType","laser");
	}

	void FixedUpdate() {
		//Debugging
		if (Input.GetMouseButton(2)) {
			Debug.Log(currentHeat);
		}

		//Turn the transform into a vector 2
		Vector2 laserOrigin = new Vector2(laserPos.position.x,laserPos.position.y);
		//Calculate miss position
	 	Vector3 laserPosMiss = new Vector3(laserPos.position.x + laserDistance,laserPos.position.y,laserPos.position.z);
		//Check for Shot to be triggered
		if((Input.GetButton("Fire")) && (canShoot)){
			//Increase the heat of the laser
			currentHeat = currentHeat + 1 * Time.deltaTime;
			//"Fire" the laser
			RaycastHit2D hit = Physics2D.Raycast(laserOrigin,Vector2.right,laserDistance);
			//Turn on the laser "visually"
			laserVisual.SetWidth(laserWidth,laserWidth);
			//Set laser positions
			laserVisual.SetPosition(0,laserPos.position);
			//Check if an object is hit and act acordingly
			if (hit.collider != null) {
				laserVisual.SetPosition(1,hit.point);

				if (hit.transform.tag == "CollisionObj") {
					//Access the health of the hit object
					health	hitHealth = hit.transform.gameObject.GetComponent<health>();
				
					//Damage the hit object
					if(hitHealth != null) {
						hitHealth.takeDamage(laserDamage * Time.deltaTime);
					}
				}
			}
			else {
				laserVisual.SetPosition(1,laserPosMiss);
			}
			
		}
		else {
			//"Turn off" laser
			laserVisual.SetWidth(0,0);
		}

		//Make the laser unable to shoot if the temperature is to high
		if (currentHeat > maxHeat) {
			canShoot = false;
			InvokeRepeating("cool",coolDelay,Time.deltaTime);
			laserVisual.SetWidth(0,0);
		}

		PlayerPrefs.SetString("ammo",laserHeatMessage + currentHeat);
	}

	//Cool the laser
	void cool() {
		currentHeat = currentHeat - coolRate * Time.deltaTime;
		if (currentHeat <= 0) {
			currentHeat = 0;
			canShoot = true;
			CancelInvoke("cool");
		}
	}
	
}

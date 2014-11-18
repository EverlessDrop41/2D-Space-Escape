using UnityEngine;
using System.Collections;

[RequireComponent(typeof(ShipControll))]
public class fuelSystem : MonoBehaviour {

	public GameObject fuelPickUp;
	
	private float currentFuel;
	public float startingFuel;
	private ShipControll ship;

	void Awake()
	{
		ship = GetComponent<ShipControll>();
	}

	void Update () 
	{
		currentFuel -= (0.1f * Time.deltaTime);

		if (currentFuel <= 0) 
			ship.crash();
	}

	void getFuel(){}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "FuelObj")
		{
			//TODO: write Fuel Refil
		}
		
		Debug.Log("Hit");
	}
}

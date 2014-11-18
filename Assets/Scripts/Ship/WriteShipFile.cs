using UnityEngine;
using System.Collections;
using System.IO;

public class WriteShipFile : MonoBehaviour {


	#region Tempc IO code
    /*Ship File Construction
     * 
     * If weapon is not recognised (!= laser || gun) it and ammo/maxheat will not be written to the file
     * Line 1 = ShipSpeed
     * line 2 = VerticalSpaeed
     * Line 3 = Weapon - (LowerCase, "gun" || "laser")
     * Line 4 = Ammo/MaxHeat - (gun = Ammo || laser = MaxHeat)
     */
	/*
    public string shipname;
    public string filetype = "ship";
    public float ShipSpeed = 10;
    public float VerticalSpeed = 1;
    public string ShipWeapon = "gun";
    public int Ammo = 1;
    public float Maxheat = 1f;

    void Awake()
    {
        if (!Directory.Exists(@".\Ships"))
        {
            Directory.CreateDirectory(@".\Ships");
        }

        StreamWriter ship = new StreamWriter(@".\Ships\" + shipname + "." + filetype);

            ship.WriteLine(ShipSpeed);
            ship.WriteLine(VerticalSpeed);

            switch (ShipWeapon.ToLower())
            {
                case "gun":
                    ship.WriteLine(ShipWeapon);
                    ship.WriteLine(Ammo);
                    break;
                case "laser":
                    ship.WriteLine(ShipWeapon);
                    ship.WriteLine(Maxheat);
                    break;
                default:
                    Debug.LogWarning("ShipWeapon is not recognised, has not been written to file");
                    break;
            }

        ship.Close();
    }
    */
	#endregion



}

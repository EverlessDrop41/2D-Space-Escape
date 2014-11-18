using UnityEngine;
using System.Collections;
using System.IO;

[RequireComponent(typeof(laserGun))]
[RequireComponent(typeof(ShipGun))]
[RequireComponent(typeof(fuelSystem))]
public class ShipControll : MonoBehaviour
{   
    /*Ship File Construction
     * 
     * If weapon is not recognised (!= laser || gun) it and ammo/maxheat will not be written to the file
     * Line 1 = ShipSpeed
     * line 2 = VerticalSpaeed
     * Line 3 = Weapon - (LowerCase, "gun" || "laser")
     * Line 4 = Ammo/MaxHeat - (gun = Ammo || laser = MaxHeat)
     */

    public float speed = 10f;
    public float verticalSpeed = 5f;
    private float verticalMoveSpeed;
    public string GameOverScene;

    void Update()
    {

        verticalMoveSpeed = Input.GetAxis("Vertical") * verticalSpeed;
		
        #if UNITY_ANDROID
            for (int i = 0; i < Input.touches.Length; i++)
            {
                if (Input.touches[i].position.y >= Screen.height / 2)
                {
                    verticalMoveSpeed = verticalSpeed;
                    Debug.Log("Up");
                }
                else if (Input.touches[i].position.y < Screen.height / 2)
                {
                    verticalMoveSpeed = verticalSpeed * -1;
                    Debug.Log("Down");
                }
            }
        #endif

        transform.position += new Vector3(speed, verticalMoveSpeed, 0) * Time.deltaTime;
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "CollisionObj" || coll.gameObject.tag == "Catcher")
        {
            crash();
        }

        Debug.Log("Hit");
    }

   public void crash()
    {
        Application.LoadLevel(GameOverScene);
    }

    /*
    #region testFail
    public string fileName,fileType;

	private float speed = 10f;
	private float verticalMoveSpeed;
	private float verticalSpeed;
	public string GameOverScene;

    void Awake()
    {
        laserGun laser = GetComponent<laserGun>();
        ShipGun gun = GetComponent<ShipGun>();

        StreamReader ShipData = new StreamReader(@".\Ships\" + fileName + fileType);
        speed = float.Parse(ShipData.ReadLine());
        verticalSpeed = float.Parse(ShipData.ReadLine());
        if (ShipData.EndOfStream)
        {
            laser.gameObject.SetActive(false);
            gun.gameObject.SetActive(false);
        }
        else
        {
            string weapon = ShipData.ReadLine();

            switch (weapon.ToLower())
            {
                case "laser":
                    gun.gameObject.SetActive(false);
                    laser.gameObject.SetActive(true);
                    laser.maxHeat = float.Parse(ShipData.ReadLine());
                    break;
                case "gun":
                    gun.gameObject.SetActive(true);
                    laser.gameObject.SetActive(false);
                    gun.startingAmmo = int.Parse(ShipData.ReadLine());
                    break;
                default:
                    Debug.Log("Weapon not recognised");
                    break;
            }
        }
        ShipData.Close();
    }

	void Update() {
         
		verticalMoveSpeed = Input.GetAxis("Vertical") * verticalSpeed;

		transform.position += new Vector3(speed,verticalMoveSpeed,0) * Time.deltaTime;
	}

	void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag == "CollisionObj" || coll.gameObject.tag == "Catcher")
        {
			crash();
		}

		Debug.Log("Hit");
	}

	void crash() {
		Application.LoadLevel(GameOverScene);
    }
    #endregion
    */
}

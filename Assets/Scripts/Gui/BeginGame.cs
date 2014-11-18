using UnityEngine;
using System.Collections;

public class BeginGame : MonoBehaviour {

   // public string shipname;

    public void StartGame(string ship)
    {
        PlayerPrefs.SetString("ShipChoice", ship);

        Application.LoadLevel("GamePlay");
    }

}

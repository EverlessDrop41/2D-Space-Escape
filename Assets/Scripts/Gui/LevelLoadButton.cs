using UnityEngine;
using System.Collections;

public class LevelLoadButton : MonoBehaviour {

	public string levelToLoad;
	public bool QuitButton;

	public void loadLevel(string level)
    {
        if (level != "quit")
        {
            Application.LoadLevel(level); 
        }
        else
        {
            Application.Quit();
        }
    } 
}

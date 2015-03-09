using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {
	public bool GameOn;

	
	// Use this for initialization
	void Start () 
	{
		Screen.orientation = ScreenOrientation.PortraitUpsideDown;
		GameOn = false;
	}
	
	// Update is called once per frame
	void Update () 
	{



		if (GameOn == false) 
		{
			if (Input.GetMouseButtonDown(0))
			{
				GameOn = true;
			}
		}
	}
}

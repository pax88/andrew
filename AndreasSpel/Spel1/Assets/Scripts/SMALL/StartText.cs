using UnityEngine;
using System.Collections;

public class StartText : MonoBehaviour {
	public GameObject Thisone;
	public Game Game;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Game.GameOn == true) 
		{
			Destroy(Thisone);
		}
	}
}

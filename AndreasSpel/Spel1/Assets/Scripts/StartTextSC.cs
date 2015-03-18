using UnityEngine;
using System.Collections;

public class StartTextSC : MonoBehaviour {
	public PlayerSC PlayerSC;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (PlayerSC.PlayGame == true) 
		{
			DestroyObject(gameObject);
		}
	}
}

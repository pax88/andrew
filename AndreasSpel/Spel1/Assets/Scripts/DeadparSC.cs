using UnityEngine;
using System.Collections;

public class DeadparSC : MonoBehaviour {
	//public PlayerSC PlayerSC;
	public Transform Player;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.position = Player.position;
	}
}

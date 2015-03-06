using UnityEngine;
using System.Collections;

public class CameraSC : MonoBehaviour {
	public Transform Player;
	public float Camerah;
	public float Camerad;

	// Use this for initialization
	void Start () 
	{
		transform.LookAt (Player);
	}
	
	// Update is called once per frame
	void Update () 
	{	

		transform.position = Player.position + new Vector3 (0, Camerah, Camerad);
	}

	void FixedUpdate()
	{

	}
}

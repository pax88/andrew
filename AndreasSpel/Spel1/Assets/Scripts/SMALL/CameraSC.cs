using UnityEngine;
using System.Collections;

public class CameraSC : MonoBehaviour {
	public Transform Player;
	public float Camerah;
	public float Camerad;
	public Deadpar Deadpar;

	// Use this for initialization
	void Start () 
	{
		transform.LookAt (Player);
	}
	
	// Update is called once per frame
	void Update () 
	{	
		if (Deadpar.IsDead == false)
		{
			transform.position = Player.position + new Vector3 (0, Camerah, Camerad);
		}
	}

	void FixedUpdate()
	{

	}
}

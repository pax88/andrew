using UnityEngine;
using System.Collections;

public class CamreaSC : MonoBehaviour {
	public Transform LookAt;
	public float CameraHeight;
	public float CameraDistance;
	public float SmallTimer;
	public PlayerSC PlayerSC;

	// Use this for initialization
	void Start () 
	{
		SmallTimer = 1;

	}
	
	// Update is called once per frame
	void Update () 
	{

		if (SmallTimer == 0) 
		{
			transform.LookAt(LookAt);
		}

		if (SmallTimer > -1) 
		{
			SmallTimer -= 1;
		}

		if (PlayerSC.Dead == false)
		{
			transform.position = LookAt.position + new Vector3 (0, CameraHeight, CameraDistance);
		}


	}

	void FixedUpdate ()
	{

	}
}

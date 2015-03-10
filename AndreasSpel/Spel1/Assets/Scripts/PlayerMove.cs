using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
	public float Speed;
	public float TurnSpeed;
	public bool TurnRight;
	public Game Game;
	public Deadpar Deadpar;

	// Use this for initialization
	void Start () 
	{
		if (Application.loadedLevel == 3)
		{
			Speed = 10;
		}else if (Application.loadedLevel == 4)
		{
			Speed = 15;
		}

		TurnRight = true;
	}
	
	// Update is called once per frame
	void Update () 
	{



		if (TurnRight == true && Input.GetMouseButtonDown (0) && Game.gameObject == true) 
		{
			TurnRight = false;
		} else if (TurnRight == false && Input.GetMouseButtonDown (0)) 
		{
			TurnRight = true;
		}
	}

	void FixedUpdate()
	{
		if (Game.GameOn == true && Deadpar.IsDead == false) 
		{
			if (TurnRight == true) 
			{
				rigidbody.AddForce (TurnSpeed, 0, 0);
			}

			if (TurnRight == false) 
			{
				rigidbody.AddForce (-TurnSpeed, 0, 0);
			}

			rigidbody.AddForce (0, 0, Speed);
		}
	}
}

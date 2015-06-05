using UnityEngine;
using System.Collections;

public class BalanceDown : MonoBehaviour {
	public float Rotationspeed;
	public Rigidbody RB;


	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{

		if (Input.GetKey(KeyCode.A))
		{
			transform.Rotate(0, 0, Rotationspeed);
		}else if (Input.GetKey(KeyCode.D))
		{
			transform.Rotate(0, 0, -Rotationspeed);
		}

		if (Input.GetMouseButton(0))
		{
			if (Input.mousePosition.x > 190)
			{
				transform.Rotate(0, 0, -Rotationspeed);
			}else transform.Rotate(0, 0, Rotationspeed);
		}
	}
}

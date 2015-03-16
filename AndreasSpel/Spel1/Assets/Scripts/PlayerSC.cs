using UnityEngine;
using System.Collections;

public class PlayerSC : MonoBehaviour {
	public float PlayerSpeed;
	public bool TurnRight;
	public bool PlayGame;
	public float TurnSpeed;
	public int SmallTimer;
	public ParticleSystem DeadPar;
	public bool Dead;
	// Use this for initialization
	void Start () 
	{
		PlayerSpeed = 8f;
		TurnSpeed = 30f;
		Dead = false;
		SmallTimer = 30;
		PlayGame = false;
		TurnRight = true;
	}
	
	// Update is called once per frame
	void Update () 
	{

		if (SmallTimer <= 0)
		{
			Application.LoadLevel(Application.loadedLevel);
		}

		if (transform.position.y < 0) 
		{
			DeadFunction();
		}




		if (PlayGame == false && Input.GetMouseButtonDown(0))
		{
			PlayGame = true;
		}



		if (TurnRight == true && Input.GetMouseButtonDown (0)) 
		{
			TurnRight = false;
		} else if (Input.GetMouseButtonDown (0)) 
		{
			TurnRight = true;
		}

	}

	void FixedUpdate()
	{
		if (Dead == true) 
		{
			SmallTimer -= 1;
		}

		if (PlayGame == true && Dead == false) 
		{
			if (TurnRight == true)
			{
				rigidbody.AddForce(TurnSpeed, 0, 0);
			} else 
			{
				rigidbody.AddForce(-TurnSpeed, 0, 0);
			}

			rigidbody.AddForce (0, 0, PlayerSpeed);
		}
	}




	void OnTriggerEnter (Collider Info)
	{
		if (Info.tag == "Deadly") 
		{
			DeadFunction();
		}
	}

	void DeadFunction()
	{
		DeadPar.Play ();
		Debug.Log("ehj");
		Dead = true;
		Destroy (GetComponent("Rigidbody"));
		Destroy (GetComponent("CapsuleCollider"));
		Destroy (GetComponent ("MeshRenderer"));
	}

}

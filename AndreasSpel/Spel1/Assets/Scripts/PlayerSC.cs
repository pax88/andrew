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
	public Transform PlayerObject;
	public GameObject Remember;
	 
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

		if (transform.position.y < 1.3) 
		{
			DeadFunction();
		}



		if (Input.mousePosition.x > 50f)
		{
			if (PlayGame == false && Input.GetMouseButtonDown(0))
			{
				PlayGame = true;
			}
		}


		Vector3 mousePosition = Input.mousePosition;
		if (Input.mousePosition.x > 50f)
		{
			if (TurnRight == true && Input.GetMouseButtonDown (0)) 
			{
				TurnRight = false;
			} else if (Input.GetMouseButtonDown (0)) 
			{
				TurnRight = true;
			}
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
		if (Info.tag == "Deadly") {
			DeadFunction ();
		} else if (Info.tag == "Goal") 
		{
			Application.LoadLevel(Application.loadedLevel + 1);
		}
	}

	void DeadFunction()
	{
		DontDestroyOnLoad (Remember);
		DeadPar.Play ();
		Dead = true;
		Destroy (GetComponent("Rigidbody"));
		Destroy (GetComponent("CapsuleCollider"));
		Destroy (GetComponent ("MeshRenderer"));
		transform.position = PlayerObject.position + new Vector3 (0f, 0.1f, 0f);
	}

}

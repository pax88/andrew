using UnityEngine;
using System.Collections;

public class Deadpar : MonoBehaviour {
	public Transform Player;
	public ParticleSystem DeadPar;
	private int SmallTimer;
	public bool IsDead;
	public Game Game;
	public GameObject PlayerObject;


	// Use this for initialization
	void Start () 
	{
		IsDead = false;
		SmallTimer = 30;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (SmallTimer <= 0) 
		{
			Application.LoadLevel(Application.loadedLevel);
		}

		if (IsDead == false) 
		{
			transform.position = Player.position;
		}
	}

	void FixedUpdate()
	{
		if (SmallTimer > 0 && IsDead == true)
		{
			SmallTimer -= 1;
		}
	}

	public void Die ()
	{
		if (IsDead == false) 
		{
			Destroy (PlayerObject.GetComponent ("MeshRenderer"));

			Game.GameOn = false;
			DeadPar.Play ();
			IsDead = true;
		}

	}
}

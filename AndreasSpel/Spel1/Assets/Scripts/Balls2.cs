using UnityEngine;
using System.Collections;

public class Balls2 : MonoBehaviour {
	public InGame InGame;
	public float DeadZone;
	public ParticleSystem DeadPar;

	// Use this for initialization
	void Start () 
	{
	
	}

	void FixedUpdate ()
	{
		transform.Translate (Input.acceleration.z, 0, 0);
	}




	
	// Update is called once per frame
	void Update () 
	{
		if (transform.position.y < DeadZone)
		{
			Destroy(GetComponent<Rigidbody>());
			Destroy(GetComponent<MeshRenderer>());
			Destroy(GetComponent<SphereCollider>());
			DeadPar.Play();
			InGame.Die();
		}
	}
}

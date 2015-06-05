using UnityEngine;
using System.Collections;

public class Balls : MonoBehaviour {
	public InGame InGame;
	public float DeadZone;
	public ParticleSystem DeadPar;

	// Use this for initialization
	void Start () 
	{
	
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

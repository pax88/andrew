using UnityEngine;
using System.Collections;

public class PlayerDead : MonoBehaviour {

	void OnTriggerEnter(Collider info)
	{
		if (info.tag == "Deadly")
		{
			Dead();
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (transform.position.y < 1)
		{
			Dead();
		}
	}

	void Dead()
	{
		Application.LoadLevel (Application.loadedLevel);
	}
}

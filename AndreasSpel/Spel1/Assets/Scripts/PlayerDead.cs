using UnityEngine;
using System.Collections;

public class PlayerDead : MonoBehaviour {

	public Deadpar Deadpar;


	void OnTriggerEnter(Collider info)
	{
		if (info.tag == "Deadly") {
			Dead ();
		} else if (info.tag == "Goal" && Deadpar.IsDead == false) 
		{
			Application.LoadLevel(Application.loadedLevel + 1);
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
		Deadpar.Die ();
	}
}

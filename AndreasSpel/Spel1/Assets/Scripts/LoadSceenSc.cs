using UnityEngine;
using System.Collections;

public class LoadSceenSc : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void LoadSceen (int Levelnr)
	{
		Application.LoadLevel (Levelnr);
	}



}

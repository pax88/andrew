﻿using UnityEngine;
using System.Collections;

public class ChangeLevel : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	public void Levelselect (int Levelselected)
	{
		Application.LoadLevel (Levelselected);
	}
}

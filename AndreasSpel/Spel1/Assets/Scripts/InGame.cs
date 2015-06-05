using UnityEngine;
using System.Collections;

public class InGame : MonoBehaviour {
	public int HigheScore;
	public int CurrentScore;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Die2 ()
	{
		Application.LoadLevel (Application.loadedLevel);
	}


	public void Die ()
	{
		if (CurrentScore > HigheScore)
		{
			HigheScore = CurrentScore;
		}
		Invoke ("Die2", 0.2f);
	}
}

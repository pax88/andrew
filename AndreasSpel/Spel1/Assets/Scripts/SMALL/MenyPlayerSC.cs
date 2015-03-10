using UnityEngine;
using System.Collections;

public class MenyPlayerSC : MonoBehaviour {
	public float RotationSpeed;
	public bool MusicOff;
	public AudioClip BGMC;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Rotate (0, RotationSpeed * Time.deltaTime, 0, Space.World);
	}

	public void SelectLevel(int Level)
	{
		Application.LoadLevel (Level);
	}

	public void MusicToggle()
	{
		if (MusicOff == true) 
		{
			audio.PlayOneShot (BGMC, 1f);
			MusicOff = false;
		} else if (MusicOff == false) 
		{
			audio.Stop ();

			MusicOff = true;
		}
	}
}

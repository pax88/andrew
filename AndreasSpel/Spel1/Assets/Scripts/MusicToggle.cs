using UnityEngine;
using System.Collections;

public class MusicToggle : MonoBehaviour {
	public bool Music;
	public AudioClip BackgroundMusic;

	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	public void MusictToggleFunction ()
	{
		if (Music == true) 
		{
			audio.PlayOneShot(BackgroundMusic, 5);
			Music = false;
		} else if (Music == false)
		{
			audio.Stop();
			Music = true;
		}
	}
	               
}

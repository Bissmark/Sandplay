using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class Video : MonoBehaviour 
{
	//public MovieTexture movie;
	private float roundTimeSeconds = 5.0f;
	private float startTime;
	private float timeLeft;
	
	void Start()
	{
		Movie();
	}	
	
	void Update()
	{
		timeLeft = Time.time - startTime;
		if(timeLeft >= roundTimeSeconds)
		{
			//movie.Stop();
            GetComponent<AudioSource>().Stop();
			//gameObject.SetActive(false);
		}
	}
	
	void Movie()
	{
		startTime = Time.time;
		gameObject.SetActive(true);
		//renderer.material.mainTexture = movie as MovieTexture;
		//audio.clip = movie.audioClip;
		//movie.Play();
        GetComponent<AudioSource>().Play();
	}
}

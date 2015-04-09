using UnityEngine;
using System.Collections;

public class SoundChange : MonoBehaviour 
{
	public GameObject soundEnabledIcon;
	public GameObject soundDisabledIcon;
	public AudioSource music;
	
	public void SoundMute() 
	{
		if(soundEnabledIcon.activeSelf == false)
		{
			soundEnabledIcon.SetActive(true);
			soundDisabledIcon.SetActive(false);
			music.mute = false;
		}
		else
		{
			soundEnabledIcon.SetActive(false);
			soundDisabledIcon.SetActive(true);
			music.mute = true;
		}
	}
}

using UnityEngine;
using System.Collections;

public class SoundChange : MonoBehaviour 
{
	public GameObject soundEnabledIcon;
	public GameObject soundDisabledIcon;
	public AudioSource music;
    private float volume = 0;
	
	public void SoundMute() 
	{
		if(soundEnabledIcon.activeSelf == false)
		{
			soundEnabledIcon.SetActive(true);
			soundDisabledIcon.SetActive(false);
            music.volume = volume;
			//music.mute = false;
		}
		else
		{
			soundEnabledIcon.SetActive(false);
			soundDisabledIcon.SetActive(true);
            volume = music.volume;
            music.volume = 0;
            //music.mute = true;
		}
	}
}

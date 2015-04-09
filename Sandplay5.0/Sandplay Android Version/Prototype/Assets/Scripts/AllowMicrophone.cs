using UnityEngine;
using System.Collections;

public class AllowMicrophone : MonoBehaviour 
{
	 IEnumerator Start() 
	 {
        yield return Application.RequestUserAuthorization(UserAuthorization.WebCam | UserAuthorization.Microphone);
        
		if (Application.HasUserAuthorization(UserAuthorization.WebCam | UserAuthorization.Microphone)) 
		{
			//audio.clip = Microphone.Start("Built-in Microphone", true, 20, 44100);
        }
		//else 
		//{
        //}
    }

    //public void Audio() 
	//{
        //audio.clip = Microphone.Start("Built-in Microphone", true, 20, 44100);
        //audio.Play();
   // }
}
using UnityEngine;
using System.Collections;

public class UpdateForFullscreen : MonoBehaviour 
{
	// Update is called once per frame
	void Update () 
	{
		#if UNITY_WEBGL
		
		if (!Screen.fullScreen && (Screen.width != 960 && Screen.width != 800 && Screen.width != 1280)) {
			Screen.SetResolution(1280, 720, false);
		}
		
		#endif
	}
}

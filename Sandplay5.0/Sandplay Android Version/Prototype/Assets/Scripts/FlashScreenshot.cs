using UnityEngine;
using System.Collections;

public class FlashScreenshot : MonoBehaviour 
{
	public GUITexture trollImage;
 
	void Start () 
	{
		trollImage.enabled = false;
	}
 
	void OnClick () 
	{
		trollImage.enabled = true;
	 
		while (trollImage.color.a > 0) 
		{
			//trollImage.color.a -= 1 * Time.deltaTime;
			//yield;
		}
			GetComponent<Collider>().enabled = false; //Disables the collider so event only happens once
		}
}
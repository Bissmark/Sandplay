using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OpenSandbox : MonoBehaviour 
{
	bool isSandboxOpen = false;
	public Animator sandboxAnimation;
	
	public void LetsWork () 
	{
		if (isSandboxOpen == false) 
		{
			sandboxAnimation.Play ("Highlighted");
			isSandboxOpen = true;
		} 
		else 
		{
			sandboxAnimation.Play ("Disabled");
			isSandboxOpen = false;
		}
	}
}
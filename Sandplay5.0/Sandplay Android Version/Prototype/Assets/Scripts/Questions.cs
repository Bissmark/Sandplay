using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Questions : MonoBehaviour 
{
	private bool questioning = false;
	public GameObject questionButton;
	public GameObject questionBackground;
	public GameObject questionButtonText;
	public QuestionLogic questionLogic;	
	
	public void ShowQuestion() 
	{
		questioning = !questioning;
		
		if(questioning)
		{
			Debug.Log("Test");
			questionLogic.UpdateContent();
			questionBackground.active = true;
			questionButtonText.GetComponent<Text>().text = "Welcome to Sandplay";
			questioning = false;
		}
		else
		{			
			questionLogic.HideContent();
			questionBackground.active = false;
			questionButtonText.GetComponent<Text>().text = "Show Question";
		}
	}
	
	public void Tween() 
	{		
		//ToggleMenu();
		//objectsTween.Play(true);	
	}
}
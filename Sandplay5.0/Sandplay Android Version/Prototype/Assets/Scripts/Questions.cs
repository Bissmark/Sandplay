using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Questions : MonoBehaviour 
{
	private bool questioning = false;
	public GameObject questionBackground;
	public GameObject questionButtonText;
	public QuestionLogic questionLogic;	
	
	public void ShowQuestion() 
	{
		//questioning = !questioning;

		if(!questioning)
		{
			questioning = true;
			questionLogic.UpdateContent();
			questionBackground.SetActive(true);
			questionButtonText.GetComponent<Text>().text = "Welcome to Sandplay";

		}
		else
		{
			questioning = false;
			questionLogic.HideContent();
			questionBackground.SetActive(false);
			questionButtonText.SetActive(false);
		}
	}
}
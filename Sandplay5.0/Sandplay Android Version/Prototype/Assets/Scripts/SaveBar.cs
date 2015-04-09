using UnityEngine;
using System.Collections;

public class SaveBar : MonoBehaviour 
{
	public GameObject buttonSave;

	// Use this for initialization
	public void OnClick()
	{
		if (buttonSave.activeSelf == false) 
		{
			buttonSave.SetActive (true);
		} 
		else 
		{
			buttonSave.SetActive(false);
		}
	}
}
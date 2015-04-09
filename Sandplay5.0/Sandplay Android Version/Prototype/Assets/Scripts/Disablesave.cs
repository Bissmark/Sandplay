using UnityEngine;
using System.Collections;

public class Disablesave : MonoBehaviour 
{

	public GameObject saveInput;
	// Use this for initialization
	void OnClick()
	{
		saveInput.SetActive(false);
	}
}
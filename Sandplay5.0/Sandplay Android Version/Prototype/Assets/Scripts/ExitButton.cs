using UnityEngine;
using System.Collections;

public class ExitButton : MonoBehaviour 
{
	public ObjectSpawner buttonExit;

	// Use this for initialization
	void OnClick()
	{
		buttonExit.MainMenu ();
	}
}

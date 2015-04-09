using UnityEngine;
using System.Collections;

public class LoadScene : MonoBehaviour 
{
	public GameObject loadMenu;
	
	void OnClick() 
	{
		if (loadMenu.activeSelf == true) 
		{
			loadMenu.SetActive(false);
		}
	}
}
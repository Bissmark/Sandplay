using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class Item
{
	public string name;
	public string icon;
}

public class CreateScrollList : MonoBehaviour 
{
	public GameObject samepleScreenshot;
	public List<Item> itemList;

	// Use this for initialization
	void Start () 
	{
		PopulateList ();
	}
	
	// Update is called once per frame
	void PopulateList () 
	{
		//foreach (GameObject item in Item) 
		//{
		//	GameObject newScreenshot = Instantiate (samepleScreenshot) as GameObject;
		//	samepleScreenshot button = newScreenshot.GetComponent<
		//}
	}
}

using UnityEngine;
using System.Collections;

public class EnableOnHover : MonoBehaviour {

	public GameObject self;
	public GameObject whiteBox;

	// Use this for initialization
	void Start() 
	{
		self.SetActive(false);
		if(whiteBox.activeSelf == true)
		{
			self.SetActive(false);
		}
	}
	// Update is called once per frame
	void OnHover(bool isDown) 
	{
		if (isDown)
			self.SetActive(true);
		else 
			self.SetActive(false);
	}
}

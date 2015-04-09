using UnityEngine;
using System.Collections;

public class SwipeAndroid : MonoBehaviour 
{
	public Transform model; // Drag your player here
	private Vector2 fp;  // first finger position
	private Vector2 lp;  // last finger position
	private	GameObject rotateIcon;
	
	public void Start()
	{
		rotateIcon = GameObject.Find("UnlockedRotate");
	}

	public void Update()
	{
		if(rotateIcon.activeSelf == true)
		{
			Debug.Log("Test");
			foreach (Touch touch in Input.touches)
			{
				if (touch.phase == TouchPhase.Began)
				{
					fp = touch.position;
					lp = touch.position;
				}
				if (touch.phase == TouchPhase.Moved)
				{
					lp = touch.position;
				}
				if(touch.phase == TouchPhase.Ended)
				{ 
					if((fp.x - lp.x) > 80) // left swipe
					{
						model.Rotate(0,-90,0);
					}
					else if((fp.x - lp.x) < -80) // right swipe
					{
						model.Rotate(0,90,0);
					}
				}
			}
		}
	}
}
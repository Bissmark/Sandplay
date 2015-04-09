using UnityEngine;
using System.Collections;

public class BackgroundColourChange : MonoBehaviour 
{
	
	public Texture[] moods;
	int index = 0;
	int prevIndex;
	
	float lerp = 1;
	float speed = 1.0f;
	
	void Start () {
	
		prevIndex = moods.Length-1;
		
	}
	
	// Update is called once per frame
	void Update () {
	
		if(lerp < 1){
			
			lerp += speed * Time.deltaTime;
			
		}
		
		//camera.backgroundColor = Color.Lerp(moods[prevIndex],moods[index],lerp);
		
	}
	
	public void NextMood () 
	{
		
		prevIndex = index;
		index = (index + 1) % moods.Length;
		lerp = 0;
		
	}
}

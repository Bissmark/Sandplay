using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;

public class readScreenshot : MonoBehaviour 
{	
	RawImage selfScreenshot;
	Screenshot screenshotBase;
	public string filePath = Application.persistentDataPath;
	
	void Start()
	{
		selfScreenshot = GetComponent<RawImage>();
		
		if(File.Exists(filePath))
		{
			//var bytes = File.ReadAllBytes(filePath);
			//Texture2D screenshot = new Texture2D(0, 0, TextureFormat.ARGB32, false);
			//screenshot.LoadImage(bytes);
			//selfScreenshot.mainTexture = screenshot;
		}		
	}
}

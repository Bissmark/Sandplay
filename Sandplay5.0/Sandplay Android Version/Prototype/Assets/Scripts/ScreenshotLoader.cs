using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;


public class ScreenshotLoader : MonoBehaviour {

	public Transform _screenshot_parent;
	public GameObject _preview_prefab;
	public GameObject screenshotHelp;
	Screenshot testPath;

	// Use this for initialization
	void Start () 
	{
		LoadScreens();
	}

	string[] GetScreenShotNames()
	{
		if (Application.platform == RuntimePlatform.WebGLPlayer || Application.platform == RuntimePlatform.OSXWebPlayer) 
		{
			return Directory.GetFiles (Application.dataPath + "/StreamingAssets/");
		} 
		else 
		{
			return Directory.GetFiles (Application.dataPath + "/Screenshots");
		}
		return Directory.GetFiles (Application.dataPath + "/Sand Play Web Build.unity3d");
	}

	public void LoadScreens()
	{
		string[] filenames = GetScreenShotNames();

		if (filenames.Length == 0)
			return;

		int i = 0;
		foreach (string s in filenames)
		{
			FileStream fs = new FileStream(s, FileMode.Open, FileAccess.Read);
			byte[] imageData = new byte[fs.Length];
			fs.Read(imageData, 0, (int)fs.Length);

			Texture2D texture = new Texture2D(4, 4);
			texture.LoadImage(imageData);

			GameObject go = Instantiate (_preview_prefab) as GameObject;
			go.transform.SetParent(_screenshot_parent);
			go.transform.localScale = Vector3.one;
			go.transform.localPosition = new Vector3(_screenshot_parent.GetComponent<HorizontalLayoutGroup>().spacing * i, 0, 0);

			//RawImage ri = new GameObject("Image").AddComponent<RawImage>();
			//ri.texture = texture;

			go.transform.GetChild(0).GetComponent<RawImage>().texture = texture;
			fs.Close();
			++i;
		}
	}
}

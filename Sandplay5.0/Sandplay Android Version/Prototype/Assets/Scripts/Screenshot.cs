using UnityEngine;
using System.Collections;
using System.IO;

public class Screenshot : MonoBehaviour
{
	public string[] fileName;
    string folder;

    void Start()
    {
        if (Application.platform == RuntimePlatform.WebGLPlayer || Application.platform == RuntimePlatform.OSXWebPlayer)
        {
            folder = Application.dataPath + "/StreamingAssets/";//"/../Screenshots";
        }
        else
        {
            folder = Application.dataPath + "/Screenshots/";
        }
        System.IO.Directory.CreateDirectory(folder);
    }

    public void SaveScreenshot()
    {
        for (int i = 0; i < fileName.Length; i++)
        {
            Application.CaptureScreenshot(folder + fileName[i] + ".png");
        }
    }
}
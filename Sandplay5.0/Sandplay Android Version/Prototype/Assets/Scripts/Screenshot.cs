using UnityEngine;
using System.Collections;
using System.IO;
using System;

public class Screenshot : MonoBehaviour
{
    // exposed variables
    [SerializeField]
    private string fileName;

    // varibales
    private string folder;

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
        string currentDT = DateTime.Now.ToString( "yyyy-MM-dd HH.mm.ss" );

        Application.CaptureScreenshot(folder + fileName + currentDT +".png");
    }
}
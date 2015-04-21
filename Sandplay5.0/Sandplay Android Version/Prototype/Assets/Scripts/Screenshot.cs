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
            folder = Application.dataPath + "/StreamingAssets/";//"/../Screenshots"; // this will do nothing StreamingAssets don't work on the web
        }
        else if ( Application.platform == RuntimePlatform.WindowsPlayer )
        {
            folder = Application.persistentDataPath + "/Screenshots/";
        }
        else
        {
            folder = Application.dataPath + "/Screenshots/";
        }
        System.IO.Directory.CreateDirectory(folder);
    }

    public void OnClickScreenshotButton()
    {

        SaveScreenshot( this.folder, this.fileName );
    }

    public string TakeScreenShot( string folder, string fileName )
    {
         return SaveScreenshot( folder, fileName );
    }

    private string SaveScreenshot(string folder, string fileName)
    {
        string currentDT = DateTime.Now.ToString( "yyyy-MM-dd HH.mm.ss" );
        string filePath = folder + fileName + currentDT + ".png";
       
        Application.CaptureScreenshot( filePath );
        // TODO: this method is not going to work for the web.
        // Task 1: Capture screenshot using RenderTexture(web only)
        // Task 2: Upload it to the server(web only)

        return filePath;
    }
}
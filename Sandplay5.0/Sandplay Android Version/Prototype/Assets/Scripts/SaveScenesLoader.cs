using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine.UI;

public class SaveScenesLoader : MonoBehaviour
{
    [SerializeField]
    private GameObject saveEntryPrefab = null; 

    private List<SaveEntry> saveEntries = null;

    private void Start()
    {
        saveEntries = MenuLogic.Instance.GetComponent<LoadScenes>().SaveEntries;
    }

    /*
    public void LoadSaveImages(string[] filenames)
    {
        GameObject go = Instantiate( _preview_prefab ) as GameObject;
        go.transform.SetParent( _screenshot_parent );
        go.transform.localScale = Vector3.one;
        go.transform.localPosition = new Vector3( _screenshot_parent.GetComponent<HorizontalLayoutGroup>().spacing * i, 0, 0 );

        //RawImage ri = new GameObject("Image").AddComponent<RawImage>();
        //ri.texture = texture;

        go.transform.GetChild( 0 ).GetComponent<RawImage>().texture = texture;
        fs.Close();
        ++i;
    }
     */
}

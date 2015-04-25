using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class SaveSlot : MonoBehaviour
{
    private SaveEntry saveEntry = null;
    public SaveEntry SaveEntry { get { return saveEntry; } set { saveEntry = value; } }

    public void OnClick()
    {
        // check that save doesn't equal to null
        DebugUtils.Assert( saveEntry != null, "Save entry is not initialized" );

        // Start loading the scene
        MenuLogic.Instance.GetComponent<LoadScenes>().StartLoad( saveEntry );

    }
}

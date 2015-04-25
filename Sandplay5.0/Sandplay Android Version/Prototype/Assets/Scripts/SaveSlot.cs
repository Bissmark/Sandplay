using UnityEngine;
using UnityEngine.EventSystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class SaveSlot : MonoBehaviour, IPointerClickHandler
{
    private SaveEntry saveEntry = null;
    public SaveEntry SaveEntry { get { return saveEntry; } set { saveEntry = value; } }

    /// <summary>
    /// Detects double click and loads the scene
    /// </summary>
    public void OnPointerClick( PointerEventData eventData )
    {
        if ( eventData.clickCount == 2)
        {
            // check that save doesn't equal to null
            DebugUtils.Assert( saveEntry != null, "Save entry is not initialized" );

            if ( eventData.clickCount == 2 )
            {
                // Start loading the scene
                MenuLogic.Instance.GetComponent<LoadScenes>().StartLoad( saveEntry );
            }
        }

    }
}

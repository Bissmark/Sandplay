using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Linq;

public class LoadScenes : MonoBehaviour
{
    private List<SaveEntry> saveEntries = null;

    // Use this for initialization
    void Start()
    {
        // get names of the save files
        saveEntries = DeserializeSaveEntries( GetSaveGameNames() );
        foreach ( SaveEntry se in saveEntries )
        {
            Debug.Log( se._screenshot_filename );
        }
    }

    /// <summary>
    /// Returns the array of file path names
    /// </summary>
    private string[] GetSaveGameNames()
    {
        return Directory.GetFiles( Application.persistentDataPath, "Sandplay_Save*" );
    }

    /// <summary>
    /// Returns the list of SaveEntry game objects
    /// </summary>
    /// <param name="paths"></param>
    private List<SaveEntry> DeserializeSaveEntries( string[] paths )
    {
        // create serializer
        XmlSerializer deserializer = new XmlSerializer( typeof( SaveEntry ) );

        // create internal temp variables
        SaveEntry saveEntry = null;
        List<SaveEntry> saveEntries = new List<SaveEntry>();

        for ( int i = 0; i < paths.Length; i++ )
        {
            // read file and deserialize it into object
            using ( StreamReader reader = new StreamReader( paths[ i ] ) )
            {
                saveEntry = ( SaveEntry )deserializer.Deserialize( reader );
            }
            saveEntries.Add( saveEntry );
        }

        return saveEntries;
    }
}

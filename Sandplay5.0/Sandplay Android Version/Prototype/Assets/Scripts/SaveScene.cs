using UnityEngine;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Linq;


//class for each object stored in the sandbox
public class ObjectSaveEntry
{
	public string _name; /* name of the prefab type */ 

	/* transform data */
	public Vector3 _position;
	public Vector3 _scale;
	public Quaternion _rotation;
};

public class SaveEntry
{
	//the objects along with the sandbox
	public List<ObjectSaveEntry> _objects = new List<ObjectSaveEntry>();
	public int _sandbox;
	public Quaternion _sandbox_rotation;
	//take a screenshot for the load screen
	public string _screenshot_filename;
};


public class SaveScene : MonoBehaviour 
{
	ObjectSpawner _object_spawner = null;

	public static SaveEntry _save_game;
	public GameObject saveButton;

	void Start()
	{
		_object_spawner = GameObject.FindObjectOfType<ObjectSpawner>();

		if (_save_game != null)
			Load();

		_save_game = null;
	}

	public void OnSave()
	{
		SaveEntry save_game = new SaveEntry();
		save_game._sandbox_rotation = _object_spawner.transform.rotation;

		string partial_filepath = "/Sandplay_Screenshot_Save" + System.DateTime.Now.ToFileTime() + ".png";
		save_game._screenshot_filename = Application.persistentDataPath + partial_filepath;
		
		Screenshot ss = GameObject.FindObjectOfType<Screenshot>();

		ss.SaveScreenshot ();

		GameObject[] objects = GameObject.FindGameObjectsWithTag("Object");

		foreach (GameObject go in objects)
		{
			ObjectSaveEntry entry = new ObjectSaveEntry();

			entry._name = go.name;
			entry._position = go.transform.position;
			entry._scale = go.transform.localScale;
			entry._rotation = go.transform.rotation;
			save_game._objects.Add(entry);
		}

		var serializer = new XmlSerializer(typeof(SaveEntry));
		TextWriter WriteFileStream = new StreamWriter(Application.persistentDataPath + "/" + "Sandplay_Save" + System.DateTime.Now.ToFileTime());
		serializer.Serialize(WriteFileStream, save_game);
	}
	
	void Load()
	{
		_object_spawner.transform.rotation = _save_game._sandbox_rotation;
		foreach (ObjectSaveEntry ose in _save_game._objects)
		{
			GameObject go = (GameObject)Instantiate(_object_spawner.FindPanelPrefabByName(ose._name));
			go.name = ose._name;
            go.GetComponent<Rigidbody>().isKinematic = true;
			go.transform.position = ose._position;
			go.transform.localScale = ose._scale;
			go.transform.rotation = ose._rotation;
			go.transform.parent = _object_spawner.transform;
		}
	}
}
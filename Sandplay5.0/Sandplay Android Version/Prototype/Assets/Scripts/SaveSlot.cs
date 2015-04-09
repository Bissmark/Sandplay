using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class SaveSlot : MonoBehaviour
{
    public SaveEntry _save;

    public void OnClick()
    {
        GameObject.FindObjectOfType<SaveUI>().StartLoad(_save);
    }
}

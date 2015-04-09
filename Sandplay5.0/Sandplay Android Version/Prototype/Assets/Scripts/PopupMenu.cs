using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PopupMenu : MonoBehaviour 
{
	//public Video videoPlay;
	//public AllowMicrophone audioEnable;
	public ObjectSpawner mainMenu;
	public Questions questionAppear;
	public GameObject saveInput;
	public GameObject loadInput;
    float x;
	
	//private void setupPopUpListEvent(UIPopupList popupList)
	//{
	//	EventDelegate.Add(popupList.onChange, SetSelectionMenu, false);
	//}
	
	public void SetSelectionMenu()
	{
		//if (UIPopupList.current != null)
		//{
			//switch (x)//UIPopupList.current.value)
			//{
				//case "Record":	audioEnable.Audio(); break;
				//case "Show Questions": questionAppear.ShowQuestion(); break;
				//case "View Videos":	videoPlay.Movie(); break;
				//case "Load Scene": loadInput.SetActive(true); break;
				//case "Save Scene": saveInput.SetActive(true); break;
				//case "Focus": questionAppear.Focus(); break;
				//case "Exit": mainMenu.MainMenu(); break;
			//}
		//}
	}

	public void KillSaveMenu()
	{
		saveInput.SetActive(false);
	}
}
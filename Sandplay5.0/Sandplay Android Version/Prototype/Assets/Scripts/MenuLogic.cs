using UnityEngine;
using System.Collections;

public class MenuLogic : MonoBehaviour 
{
	public GameObject mainMenu;
	public GameObject loadMenu;
	public GameObject mediaMenu;
	public GameObject screenshotMenu;
	public GameObject videoMenu;
    public GameObject loginMenu;
	
	private GameObject activeMenu;
	private GameObject prevMenu;
	
	void Awake () 
	{		
		activeMenu = mainMenu;	
	}
	
	void ChangeMenu (GameObject newMenu) 
	{
		prevMenu = activeMenu;
		activeMenu.SetActive(false);
		activeMenu = newMenu;
		activeMenu.SetActive(true);
	}
	
	public void MainMenu () 
	{
		ChangeMenu(mainMenu);	
	}
	
	public void LoadMenu () 
	{	
		ChangeMenu (loadMenu);
	}
	
	public void MediaMenu () 
	{	
		ChangeMenu(mediaMenu);
	}
	
	public void ScreenshotMenu () 
	{	
		ChangeMenu(screenshotMenu);
	}

	public void VideosMenu () 
	{	
		ChangeMenu(videoMenu);
	}

    public void LoginMenu()
    {
        ChangeMenu(loginMenu);
    }
	
	public void Back () 
	{	
		ChangeMenu(prevMenu);
	}
	
	public void Play () 
	{	
		Application.LoadLevel(1);
	}
	
	public void Exit () 
	{
		Application.Quit();
	}
}
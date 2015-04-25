using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SaveBar : MonoBehaviour 
{
    [SerializeField]
	private GameObject savePanel = null;
    public GameObject SavePanel { get { return savePanel; } }

    [SerializeField]
    private InputField saveInput = null;
    public InputField SaveInput { get { return saveInput; } }

    private void Awake()
    {
        // checking for errors
        DebugUtils.Assert( savePanel != null, "Check if save panel is hooked up" );
        DebugUtils.Assert( saveInput != null, "Check if save input is hooked up" );
    }


	// Use this for initialization
	public void OnClick()
	{
		if (savePanel.activeSelf == false) 
		{
			savePanel.SetActive (true);
		} 
		else 
		{
			savePanel.SetActive(false);
		}
	}
}
using UnityEngine;
using System.Collections;

public class Load : MonoBehaviour 
{	
	//private AsyncOperation async;
	//public UIProgressBar loadingBar;

	void Start()
	{
		Application.LoadLevel("Prototype");
		//StartCoroutine(LoadTheScene());
	}
	
//	private IEnumerator LoadTheScene() 
//	{
//		Debug.Log("Loading Starts");
//		async = Application.LoadLevelAsync("Prototype");
//		async.allowSceneActivation = false;
//		
//		while (!async.isDone)
//		{
//			Debug.Log("Loading Progess: " + async.progress);
//			
//			if (async.progress == 0.9f)
//			{
//				Debug.Log("Loading Finished");
//				yield return new WaitForSeconds(1.0f);
//				async.allowSceneActivation = true;
//			}
//			yield return 0;
//		}
//    }
}
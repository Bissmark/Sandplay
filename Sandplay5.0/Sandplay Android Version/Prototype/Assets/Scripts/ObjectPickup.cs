using UnityEngine;
using System.Collections;

[RequireComponent(typeof(ObjectSpawner))]
public class ObjectPickup : MonoBehaviour {

	private ObjectSpawner oSpawner;
	private Camera oViewCamera;
	private int iTouchID = -1;
	private float fTouchTimer = 0;
	private GameObject oCurrObject = null;

	// Use this for initialization
	void Start () 
	{
		oSpawner = GetComponent<ObjectSpawner> ();
		oViewCamera = oSpawner.ViewCamera;
	}
	
	// Update is called once per frame
	void Update () 
	{
		//can't pick up if mid-spawn
		if ( oSpawner.CurrentState != SPAWN_STATE.NOT_SPAWNING )
		{
			iTouchID = -1;
			return;
		}

		if ( iTouchID == -1 )
		{
			fTouchTimer = 0;
			oCurrObject = null;
			for ( int i = 0 ; i < TouchHandler.touchCount ; ++i )
			{
				SimpleTouch t = TouchHandler.GetTouch(i);

				Ray r = oViewCamera.ScreenPointToRay(t.position);
				RaycastHit info;
				if ( Physics.Raycast(r, out info, 100f, 1 << LayerMask.NameToLayer("Object") ) )
				{
					iTouchID = t.fingerId;
					oCurrObject = info.collider.gameObject;
					break;
				}
			}
		}
		else if ( fTouchTimer < 0.5f )
		{
			SimpleTouch t = oSpawner.GetTouchByID(iTouchID);
			if ( t.phase == TouchPhase.Ended || t.fingerId == -1 )
			{
				iTouchID = -1;
				return;
			}
			fTouchTimer += Time.deltaTime;

		}
		else
		{
			oCurrObject.transform.parent = null;
            oCurrObject.GetComponent<Rigidbody>().isKinematic = true;
			//oCurrObject.transform.rotation = Quaternion.identity;

			oSpawner.PickUpPiece(oCurrObject, oSpawner.GetTouchByID(iTouchID));
			Debug.Log (oCurrObject.transform.rotation);
		}


	}
}

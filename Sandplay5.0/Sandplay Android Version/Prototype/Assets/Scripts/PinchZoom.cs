using UnityEngine;

public class PinchZoom : MonoBehaviour
{
    //public float perspectiveZoomSpeed = 0.5f;        // The rate of change of the field of view in perspective mode.
	//public float orthoZoomSpeed = 0.5f;        // The rate of change of the orthographic size in orthographic mode.
	
//    void Update()
//    {
//		 if (Input.touchCount == 2)
//        {
//            // Store both touches.
//            Touch touchZero = Input.GetTouch(0);
//            Touch touchOne = Input.GetTouch(1);
//
//            // Find the position in the previous frame of each touch.
//            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
//            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;
//
//            // Find the magnitude of the vector (the distance) between the touches in each frame.
//            float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
//            float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;
//
//            // Find the difference in the distances between each frame.
//            float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;
//
//            // If the camera is orthographic...
//			if (camera.isOrthoGraphic)
//            {
//                // ... change the orthographic size based on the change in distance between the touches.
//                camera.orthographicSize += deltaMagnitudeDiff * orthoZoomSpeed;
//
//                // Make sure the orthographic size never drops below zero.
//				camera.orthographicSize = Mathf.Max(camera.orthographicSize, 0.1f);
//            }
//            else
//            {
//                // Otherwise change the field of view based on the change in distance between the touches.
//                camera.fieldOfView += deltaMagnitudeDiff * perspectiveZoomSpeed;
//
//                // Clamp the field of view to make sure it's between 0 and 180.
//                camera.fieldOfView = Mathf.Clamp(camera.fieldOfView, 35, 60);
//            }
//         }
//    }

	public float ROTSpeed = 15;
	public float smooth = 20.0f;

    [SerializeField]
    private float lookAtOffset = 2.5f;

    [SerializeField]
    private float minFieldOfView = 35.0f;

    [SerializeField]
    private float maxFieldOfView = 60.0f;

    private float FieldOfView { get { return GetComponent<Camera>().fieldOfView; } set { GetComponent<Camera>().fieldOfView = value; } }

    private Transform target = null;


	RaycastHit hit;
	private Quaternion startPosition;
	//private bool zoomedIn = true;

	//private float alpha = 1.0f;

	void Start()
	{
		startPosition = transform.rotation;
	}

	void Update() 
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		Quaternion newRotation = Quaternion.AngleAxis(90, Vector3.up);
		float scroll = Input.GetAxis ("Mouse ScrollWheel");

		if (scroll != 0)
		{
			if (Physics.Raycast (ray, out hit, 100) && hit.collider.tag == "Object")
			{
                // acquire target model transform
                target = hit.collider.gameObject.transform;

                // look at target
                Vector3 lookAtPosition = new Vector3( target.position.x, target.position.y + lookAtOffset, target.position.z );
                GetComponent<Camera>().transform.LookAt( lookAtPosition );

                // zoom onto target
                FieldOfView = Mathf.Clamp( Mathf.Lerp( FieldOfView, FieldOfView - scroll * ROTSpeed, Time.deltaTime * smooth ), minFieldOfView, maxFieldOfView );
			}
		}
			if(Input.GetKeyDown("space"))
			{
                GetComponent<Camera>().fieldOfView = 60;
                GetComponent<Camera>().transform.rotation = startPosition;
			}
		}
	}
//}
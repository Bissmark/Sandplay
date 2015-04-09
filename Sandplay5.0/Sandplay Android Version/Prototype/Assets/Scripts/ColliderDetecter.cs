using UnityEngine;
using System.Collections;

public class ColliderDetecter : MonoBehaviour {

    void OnCollisionEnter(Collision collision) {
		
		if(collision.transform.name == "sandBoxFullMB"){
			GetComponent<Rigidbody>().isKinematic = true;
		}
    }
}

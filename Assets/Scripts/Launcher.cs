using UnityEngine;
using System.Collections;

public class Launcher : MonoBehaviour {
	public float force;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay (Collider col){
		//print ("collided with object");
		if (Input.anyKeyDown) {
			col.gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * force);
		}
	}
}

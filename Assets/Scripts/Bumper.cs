using UnityEngine;
using System.Collections;

public class Bumper : MonoBehaviour {
	public float force;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter (Collision col){
		print ("object collided");
		Vector3 newVel;
		newVel = col.relativeVelocity * -1 * force;
		col.gameObject.GetComponent<Rigidbody> ().AddForce (newVel);
	}
}

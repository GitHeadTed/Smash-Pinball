using UnityEngine;
using System.Collections;

public class AddForce : MonoBehaviour {
	public float force = 1000;

	private Rigidbody body;

	void Awake () {
		body = GetComponent<Rigidbody> ();

	}

	// Use this for initialization
	void Start () {
		print (transform.forward * force);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown) {
			body.AddForce(transform.forward * force);
		}
	}
}

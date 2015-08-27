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
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown) {
			body.AddForce(new Vector3(0,0,force));
		}
	}
}

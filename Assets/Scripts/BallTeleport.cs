using UnityEngine;
using System.Collections;

public class BallTeleport : MonoBehaviour {

	private float initialDistance;
	private SphereCollider col;

	void Awake () {
		col = GetComponent<SphereCollider> ();
	}

	// Use this for initialization
	void Start () {
		RaycastHit hit;
		if (Physics.Raycast (transform.position, Vector3.down, out hit)) {
			initialDistance = hit.distance;
			print (initialDistance);
		}
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		if (Physics.Raycast (transform.position, Vector3.down, out hit) && hit.distance > initialDistance) {
			transform.position += (hit.distance - (col.radius * 2)) * Vector3.down;
			print ("teleported ball");
		}
	
	}

	//public void Teleport(){
		//RaycastHit hit;
		//if (Physics.Raycast (transform.position, Vector3.down, out hit)) {
			//transform.position += (hit.distance - (col.radius * 2)) * Vector3.down;
			//float xVelocity = body.velocity.x;
			//float yVelocity = body.velocity.y;
			//float zVelocity = body.velocity.y;
			//yVelocity *= .5f;
			//body.velocity = new Vector3(xVelocity,yVelocity,zVelocity);
			//print ("teleported ball");
		//}
	//}
}

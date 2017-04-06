using UnityEngine;
using System.Collections;

public class RotateShip : MonoBehaviour {

	public float speed = 20f;
	public float rotationalSpeed = 10f;
	public Vector3 angVel = new Vector3 ();
	public Vector3 rotVel = new Vector3 ();
	private Rigidbody rb;
	private Vector3 mouse;


	// Use this for initialization
	void Start () {
		rb = GetComponent <Rigidbody> ();
		mouse = Input.mousePosition;
	}
	
	// Update is called once per frame
	void Update () {
		rb.freezeRotation = false;
		if (Input.GetKey (KeyCode.E)) {
			angVel = new Vector3 (0, 0, -speed);
		}

		if (Input.GetKey (KeyCode.Q)) {
			angVel = new Vector3 (0, 0, speed);
		}

		if (Input.GetKey (KeyCode.LeftShift)) {
			angVel = new Vector3 (0, 0, 0);
			rb.freezeRotation = true;
		}

		rotVel += new Vector3 (-1*(Input.mousePosition.y-Screen.height/2)/Screen.height*rotationalSpeed,(Input.mousePosition.x-Screen.width/2)/Screen.width*rotationalSpeed, 0);

		transform.Rotate (angVel * Time.deltaTime);
		transform.Rotate (rotVel * Time.deltaTime);
		angVel = angVel * 0.98f;
		rotVel = rotVel * 0.8f;
	}

}

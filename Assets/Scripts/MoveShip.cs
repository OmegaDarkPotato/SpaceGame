using UnityEngine;
using System.Collections;

public class MoveShip : MonoBehaviour {

	public float speed = 10f;
	public float frict = 0.99f;
	private Vector3 vel;
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		vel = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W)) {
			vel = vel + transform.forward*speed;
		}

		if (Input.GetKey(KeyCode.S)) {
			vel = (vel + -transform.forward*speed);
		}

		if (Input.GetKey(KeyCode.A)) {
			vel = (vel + -transform.right*speed);
		}

		if (Input.GetKey(KeyCode.D)) {
			vel = vel + transform.right*speed;
		}

		if (Input.GetKey(KeyCode.Space)) {
			vel = vel + transform.up*speed;
		}

		if (Input.GetKey(KeyCode.LeftControl)) {
			vel = (vel + -transform.up*speed);
		}

		rb.AddForce(vel*Time.deltaTime);
		vel = vel * frict;
	}
}

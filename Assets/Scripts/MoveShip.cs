using UnityEngine;
using System.Collections;

public class MoveShip : MonoBehaviour {

	public float speed = 10f;
	public float frict = 0.01f;
	private bool applyfrict = true;
	private Vector3 vel;
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		vel = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {
		applyfrict = true;
		if (Input.GetKey(KeyCode.W)) {
			vel = vel + transform.forward*speed;
			applyfrict = false;
		}

		if (Input.GetKey(KeyCode.S)) {
			vel = (vel + -transform.forward*speed);
			applyfrict = false;
		}

		if (Input.GetKey(KeyCode.A)) {
			vel = (vel + -transform.right*speed);
			applyfrict = false;
		}

		if (Input.GetKey(KeyCode.D)) {
			vel = vel + transform.right*speed;
			applyfrict = false;
		}

		if (Input.GetKey(KeyCode.Space)) {
			vel = vel + transform.up*speed;
			applyfrict = false;
		}

		if (Input.GetKey(KeyCode.LeftControl)) {
			vel = (vel + -transform.up*speed);
			applyfrict = false;
		}
		//vel = vel * frict;
		if (applyfrict == true) {
			rb.drag = (1-frict) * (vel.magnitude/100000);
			vel = vel * (frict);
			Debug.Log ("Applied Friction");

		}else{
			rb.drag = 0;
		}
		rb.AddForce (vel * Time.deltaTime);
	}
}

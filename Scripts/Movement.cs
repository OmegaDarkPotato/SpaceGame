using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	float x, y, z, moveSpeed;
	Vector3 moveVector;
	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		x = Random.Range (-3, 3);
		y = Random.Range (-3, 3);
		z = Random.Range (-3, 3);
		moveSpeed = Random.Range (1, 5);
		moveVector = new Vector3 (x, y, z) * Time.deltaTime * moveSpeed;
	}
	
	// Update is called once per frame
	void Update () {
		rb.AddForce (moveVector);
	}

	void OnCollisionEnter (Collision col) {
		Debug.Log ("collided");
	}
}

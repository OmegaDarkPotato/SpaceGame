using UnityEngine;
using System.Collections;

public class Scale : MonoBehaviour {

	float xScale, yScale, zScale, multiplier;

	// Use this for initialization
	void Start () {
		xScale = Random.Range (0, 10) + 1;
		yScale = Random.Range (0, 10) + 1;
		zScale = Random.Range (0, 10) + 1;
		multiplier = (int) Random.Range (0, 19) + 1;
		transform.localScale = new Vector3 (xScale, yScale, zScale) * multiplier;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

using UnityEngine;
using System.Collections;

public class FollowCamera : MonoBehaviour {

	[SerializeField]
	private Transform target;

	[SerializeField]
	private Vector3 offsetPosition;

	[SerializeField]
	private Space offsetPositionSpace = Space.Self;

	[SerializeField]
	private bool lookAt = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(target == null)
		{
			Debug.LogWarning("Missing target ref !", this);

			return;
		}

		// compute position
		if(offsetPositionSpace == Space.Self)
		{
			transform.position = target.TransformPoint(-offsetPosition);
		}
		else
		{
			transform.position = target.position + offsetPosition;
		}

		// compute rotation
		if(lookAt)
		{
			transform.LookAt(target);
		}
		else
		{
			transform.rotation = target.rotation;
		}
	}
}

using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	public GameObject targetObject;
	private float distanceToTarget;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float targetObjectX = targetObject.transform.position.x;
		Vector3 newCameraPosition = transform.position;
		newCameraPosition.x = targetObjectX + distanceToTarget;
		transform.position = newCameraPosition;
	}
}

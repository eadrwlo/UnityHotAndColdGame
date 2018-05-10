using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchTest2 : MonoBehaviour {
	Ray ray;
	RaycastHit hit;
	public GameObject touchSphereRange;
	// Use this for initialization
	void Start () {
		//transform.position = touchSphereRange.transform.position - Vector3.forward * 10f;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0) {
			//ray = Camera.main.ScreenPointToRay (Input.GetTouch (0).position);

			//if (Physics.Raycast (ray, out hit, Mathf.Infinity)) {
				//Debug.Log ("Hit something");
				//Destroy (hit.transform.gameObject);
			Vector3 tempVector = new Vector3 (Camera.main.ScreenToWorldPoint (Input.GetTouch (0).position).x, 
				                     Camera.main.ScreenToWorldPoint (Input.GetTouch (0).position).y,
				                     touchSphereRange.transform.position.z);
			touchSphereRange.transform.position = tempVector;
			}
		}
}

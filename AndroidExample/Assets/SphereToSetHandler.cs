using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SphereToSetHandler : MonoBehaviour {
	public GameObject touchSphereRange;
	int sphereBottomRenderMargin;
	// Use this for initialization
	void Start () {
		//transform.position = touchSphereRange.transform.position - Vector3.forward * 10f;
		int magicNumberHalfSphereHeight = 40;
		sphereBottomRenderMargin = (int)Screen.height - (int)GameObject.FindGameObjectWithTag ("hideShowSpHereButton").GetComponent<RectTransform> ().rect.height - magicNumberHalfSphereHeight;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		if ((Input.touchCount > 0) && (Input.GetTouch (0).position).y < sphereBottomRenderMargin) 
		{
			Vector3 tempVector = new Vector3 (Camera.main.ScreenToWorldPoint (Input.GetTouch (0).position).x, 
				                     Camera.main.ScreenToWorldPoint (Input.GetTouch (0).position).y,
				                     touchSphereRange.transform.position.z);
			touchSphereRange.transform.position = tempVector;
		}
	}
}

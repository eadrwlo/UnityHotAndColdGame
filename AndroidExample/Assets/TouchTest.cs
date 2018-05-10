using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0) {
			//code
			Touch tempTouch = Input.GetTouch(0);
			//Debug.Log (tempTouch.position);
		//foreach(Touch tempTouch in Input.touches){
		//		Debug.Log(tempTouch.position);
		//}
			if (tempTouch.phase == TouchPhase.Began)
				Debug.Log ("Nacisnieto");
		}
	}
}

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
		GameObject.FindGameObjectWithTag ("winLabel").GetComponent<Text> ().enabled = false;
		GameObject.FindGameObjectWithTag ("failLabel").GetComponent<Text> ().enabled = false;
		GameObject.FindGameObjectWithTag ("timeRemaining").GetComponent<Text> ().text = Hide.timeLeft + "s";
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Hide.isGameRunning) // We have to search for a ball
		{
			Hide.timeLeft -= Time.deltaTime;
			if (Hide.timeLeft < 0) {
				GameObject.FindGameObjectWithTag ("failLabel").GetComponent<Text> ().enabled = true;
				if (Hide.timeLeft < -3) {
					GameObject.FindGameObjectWithTag ("failLabel").GetComponent<Text> ().enabled = false;
				}
			} else {
				GameObject.FindGameObjectWithTag ("timeRemaining").GetComponent<Text> ().text = (int)Hide.timeLeft + "s";
			}
			if ((Input.touchCount > 0) && (Input.GetTouch (0).position).y < sphereBottomRenderMargin) {
				Vector3 sphereScreenPoint = Camera.main.WorldToScreenPoint (touchSphereRange.transform.position);
				Vector3 inputTouchPosition = Input.GetTouch (0).position;
				Debug.Log ("Wspolrzedne");
				Debug.Log ("X palec" + inputTouchPosition.x);
				Debug.Log ("Y palec" + inputTouchPosition.y);
				Debug.Log ("X KULA" + sphereScreenPoint.x);
				Debug.Log ("Y KULA" + sphereScreenPoint.y);

				//if (GameObject.FindGameObjectWithTag ("sphereToSet").GetComponent<Renderer> ().enabled == true) {
//					Vector3 tempVector = new Vector3 (Camera.main.ScreenToWorldPoint (Input.GetTouch (0).position).x, 
//						                     Camera.main.ScreenToWorldPoint (Input.GetTouch (0).position).y,
//						                     touchSphereRange.transform.position.z);
//					touchSphereRange.transform.position = tempVector;
				//} else {
				if ((inputTouchPosition.x > sphereScreenPoint.x - 40) && (inputTouchPosition.x < sphereScreenPoint.x + 40) && 
					(inputTouchPosition.y > sphereScreenPoint.y - 40) && (inputTouchPosition.y < sphereScreenPoint.y + 40)) 
				{
						Debug.Log ("Wspolrzene zgodne");
						GameObject.FindGameObjectWithTag ("sphereToSet").GetComponent<Renderer> ().enabled = true;
						GameObject.FindGameObjectWithTag ("winLabel").GetComponent<Text> ().enabled = true;
					//}
				}

			}
		} 
		else //We can set te ball position
		{
			if ((Input.touchCount > 0) && (Input.GetTouch (0).position).y < sphereBottomRenderMargin) // Make sure ball will be not set on the bottom buttons
			{
				Vector3 tempVector = new Vector3 (Camera.main.ScreenToWorldPoint (Input.GetTouch (0).position).x, 
					                    Camera.main.ScreenToWorldPoint (Input.GetTouch (0).position).y,
					                    touchSphereRange.transform.position.z);
				touchSphereRange.transform.position = tempVector;
			}
		}

	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hide : MonoBehaviour {
	public void HideSphere()
	{
		if (GameObject.FindGameObjectWithTag ("sphereToSet").GetComponent<Renderer> ().enabled == true) {
			GameObject.FindGameObjectWithTag ("hideShowSpHereButton").GetComponentInChildren<Text>(true).text = "Show ball!";
			GameObject.FindGameObjectWithTag ("sphereToSet").GetComponent<Renderer> ().enabled = false;
		} else 
		{
			GameObject.FindGameObjectWithTag ("hideShowSpHereButton").GetComponentInChildren<Text>(true).text = "Hide ball!";
			GameObject.FindGameObjectWithTag ("sphereToSet").GetComponent<Renderer>().enabled = true;
		}	

	}
}

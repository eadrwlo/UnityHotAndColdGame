using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hide : MonoBehaviour {
	public static bool isGameRunning = false;
	public static float timeLeft = 10.0f;
	public void HideSphere()
	{
		if (GameObject.FindGameObjectWithTag ("sphereToSet").GetComponent<Renderer> ().enabled == true) 
		{
			GameObject.FindGameObjectWithTag ("hideShowSpHereButton").GetComponentInChildren<Text>(true).text = "Show ball!";
			GameObject.FindGameObjectWithTag ("sphereToSet").GetComponent<Renderer> ().enabled = false;
			GameObject.FindGameObjectWithTag ("winLabel").GetComponent<Text> ().enabled = false;
			isGameRunning = true;
		} 
		else 
		{
			GameObject.FindGameObjectWithTag ("hideShowSpHereButton").GetComponentInChildren<Text>(true).text = "Hide ball!";
			GameObject.FindGameObjectWithTag ("sphereToSet").GetComponent<Renderer>().enabled = true;
			isGameRunning = false;
			timeLeft = 10.0f;
			GameObject.FindGameObjectWithTag ("timeRemaining").GetComponent<Text> ().text = (int)timeLeft + "s";
		}	
	}
}

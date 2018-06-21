using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigation : MonoBehaviour {

	public void GoToShopOnClick()
	{
		SceneManager.LoadScene("ShopScene", LoadSceneMode.Single);
	}

	public void GoToGameSceneOnClick()
	{
		SceneManager.LoadScene("GameScene", LoadSceneMode.Single);
	}
}

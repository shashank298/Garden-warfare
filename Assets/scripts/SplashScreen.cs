using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashScreen : MonoBehaviour {

	public float autoLoadNextLevelAfter;
	void Start () {
			if (autoLoadNextLevelAfter <= 0) {
				Debug.Log ("Level auto load disabled, use a postive number is seconds");
			} else {
				Invoke ("LoadNextLevel", autoLoadNextLevelAfter);
			}
		}

	public void LoadLevel(string name)
	{
		Debug.Log ("LoadNextLevel"+ name);
		Application.LoadLevel (name);
	}
	public void QuitRequest()
	{
		Debug.Log ("Quit Requested");
		Application.Quit();
	}
	public void LoadNextLevel()
	{
		Application.LoadLevel (Application.loadedLevel + 1);
	}
}

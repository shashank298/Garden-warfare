using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour {

	public float levelSeconds=100;

	private Slider slider;
	private AudioSource audioSuorce;
	private bool isEndOfLevel = false;
	private SplashScreen levelManager;
	private GameObject winLabel;
	// Use this for initialization
	void Start () {
		slider = GetComponent<Slider> ();
		audioSuorce = GetComponent<AudioSource> ();
		levelManager = GameObject.FindObjectOfType<SplashScreen> ();
		FindYouWin ();
		winLabel.SetActive (false);
	}

void FindYouWin ()
	{
		winLabel = GameObject.Find ("You win");
		if (!winLabel) {
			Debug.LogWarning ("plse cresate");
		}
	}

	// Update is called once per frame
	void Update () {
		slider.value = Time.timeSinceLevelLoad / levelSeconds;	

		bool timeIsUp = (Time.timeSinceLevelLoad >= levelSeconds);
		if (timeIsUp && !isEndOfLevel) {
			audioSuorce.Play ();
//			winLabel.SetActive (true);
			Invoke ("LoadNextLevel", audioSuorce.clip.length);
			isEndOfLevel = true;
		}
	  }
	void LoadNextLevel(){
		levelManager.LoadNextLevel ();
	}
}

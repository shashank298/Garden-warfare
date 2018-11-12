using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour {
	public Slider volumeslider;
	public Slider difficultyslider;
	public SplashScreen levelmanager;
	private MusicManager musicmanager;
	// Use this for initialization
	void Start () {
		musicmanager = GameObject.FindObjectOfType<MusicManager> ();
		//Debug.Log (musicmanager);
		volumeslider.value=playerPrefesManager.GetMasterVolume();
		difficultyslider.value = playerPrefesManager.GetDifficulty();
	}

	void Update () {
		musicmanager.SetVolume (volumeslider.value);
	}
	public void SaveandExit()
	{
		playerPrefesManager.SetMasterVolume (volumeslider.value);
		playerPrefesManager.SetDifficulty (difficultyslider.value);
		levelmanager.LoadLevel ("1scene");
	}
	public void SetDefaults()
	{
		volumeslider.value = 0.8f;
		difficultyslider.value = 2f;
	}
}

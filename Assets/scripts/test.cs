using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {
	void Start()
	{
		print(playerPrefesManager.GetMasterVolume());
		playerPrefesManager.SetMasterVolume(0.3f);
		print(playerPrefesManager.GetMasterVolume());

		print(playerPrefesManager.IsLevelUnlocked(2));
		playerPrefesManager.UnlockLevel(2);
		print (playerPrefesManager.IsLevelUnlocked (2));
	}
	void Update()
	{}
}

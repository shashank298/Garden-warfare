using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerPrefesManager : MonoBehaviour {

	const string Master_volume_key="master_volume";
	const string Difficult_key="dificulty";
	const string Level_key="level_unlocked_";

	public static void SetMasterVolume(float volume)
	{
		if (volume >= 0f && volume <= 2f) {
			PlayerPrefs.SetFloat (Master_volume_key, volume);
		} else {
			Debug.LogError ("Master volume key out of range");
		}
	}
	public static float GetMasterVolume()
	{
		return PlayerPrefs.GetFloat (Master_volume_key);
			
	}
	public static void UnlockLevel(int level)
	{
		if (level <= Application.levelCount - 1) {
			PlayerPrefs.SetInt (Level_key + level.ToString (), 1);
		} else {
			Debug.LogError ("Trying to unlock level in build order ");
		}

	}
	public static bool IsLevelUnlocked(int level)
	{
		int levelValue = PlayerPrefs.GetInt (Level_key + level.ToString ());
		bool isLevelUnlocked = (levelValue == 1);
		if (level <= Application.levelCount - 1) {
			return isLevelUnlocked;
		} else {
			Debug.LogError ("Trying to query level not in build order");
			return false;
		}
	}
	public static void SetDifficulty(float difficult)
	{
		if (difficult >= 1f && difficult <= 3f) {
			PlayerPrefs.SetFloat (Difficult_key, difficult);
		} else {
			Debug.LogError ("Difficulty out of range");
		}
	}

	public static float GetDifficulty()
	{
		return PlayerPrefs.GetFloat (Difficult_key);
	}
}

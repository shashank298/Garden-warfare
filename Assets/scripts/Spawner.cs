﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject[] attackPrefabArray;

	// Update is called once per frame
	void Update () {
		foreach (GameObject thisAttacker in attackPrefabArray) {
			if (isTimeToSpawn (thisAttacker)) {
				Spawn (thisAttacker);
			}
		}	
	}
	void Spawn(GameObject myGameObject)
	{
		GameObject myAttacker = Instantiate (myGameObject) as GameObject;
		myAttacker.transform.parent = transform;
		myAttacker.transform.position = transform.position;
	}

	bool isTimeToSpawn(GameObject attackerGameObject)
	{
		Attacker attacker = attackerGameObject.GetComponent<Attacker> ();
		float meanSpawnDelay = attacker.seenEverySeconds;
		float spawnsPerSecond = 1 / meanSpawnDelay;
		if (Time.deltaTime > meanSpawnDelay) {
			Debug.LogWarning ("Spawn rate capped byframe");
		} 
		float threshold = spawnsPerSecond * Time.deltaTime/5;
		return (Random.value < threshold);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {
	private SplashScreen levelManager;
	// Use this for initialization
	void Start () {
		levelManager = GameObject.FindObjectOfType<SplashScreen> ();
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D () {
		levelManager.LoadLevel ("1scene 5");
	}
}

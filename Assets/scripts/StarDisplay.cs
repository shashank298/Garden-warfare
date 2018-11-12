using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent (typeof(Text))]
public class StarDisplay : MonoBehaviour {
	private Text starText;
	private int stars = 0;
	public enum Status {SUCCESS, FAILURE};

	void Start () {
		starText = GetComponent<Text> ();	
		stars = 100;
		UpdateDisplay ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void AddStars(int amount)
	{
		stars += amount;
		UpdateDisplay ();
		//print (amount+"Start added to the display");
	}
	public Status UseStars(int amount)
	{
		if (stars >= amount) {
			stars -= amount;
			UpdateDisplay ();
			return Status.SUCCESS;
		} 
		return Status.FAILURE;
	}
	private void UpdateDisplay()
	{
		starText.text = stars.ToString ();
	}
}

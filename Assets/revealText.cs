using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class revealText : MonoBehaviour 
{
	void Update()
	{
		if (GameObject.Find ("GameManager").GetComponent<ScoreTracker> ().player1Score >= 5)
			GetComponent<Text> ().text = "Player 1\n";
		else
			GetComponent<Text> ().text = "Player 2\n";
	}
}

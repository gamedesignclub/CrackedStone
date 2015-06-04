using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class wins : MonoBehaviour 
{

	void Start()
	{
		GetComponent<Text> ().text = GameObject.Find ("GameManager").GetComponent<ScoreTracker> ().player1Score + " - " + GameObject.Find ("GameManager").GetComponent<ScoreTracker> ().player2Score; 
	}
}

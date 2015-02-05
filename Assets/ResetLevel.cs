using UnityEngine;
using System.Collections;

public class ResetLevel : MonoBehaviour 
{
	public GameObject player1, player2;
	public double resetZone;

	void Update () 
	{
		if (player1.transform.position.y < resetZone)
		{
			PlayerPrefs.SetInt("player1", PlayerPrefs.GetInt("player1") + 1);
			Application.LoadLevel (0);
		}
		else if (player2.transform.position.y < resetZone)
		{
			PlayerPrefs.SetInt("player2", PlayerPrefs.GetInt("player2") + 1);
			Application.LoadLevel (0);
		}

		Debug.Log ("Player 1: " + PlayerPrefs.GetInt("player1") + " Player 2: "+PlayerPrefs.GetInt("player2"));
	}
}

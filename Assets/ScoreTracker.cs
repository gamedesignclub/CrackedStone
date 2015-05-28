using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour 
{

	public int player1Score = 0, player2Score = 0;
	public Vector3 player1Pos, player2Pos;
	public GameObject player1, player2;
	public Text player1Text, player2Text;

	float a = 0f;

	void Start()
	{
		player2Pos = player2.transform.position;
		player1Pos = player1.transform.position;
	}

	void Update () {
		//code
		if (player1.transform.position.y < -11) 
		{
			player2Score++;
			player1.transform.position = player1Pos;
			player2.transform.position=  player2Pos;
		}
		else if (player2.transform.position.y < -11) 
		{
			player1Score ++;
			player1.transform.position = player1Pos;
			player2.transform.position = player2Pos;
		}

		player1Text.text = "" + player1Score;
		player2Text.text = "" + player2Score;

		if (player1Score == 5)
			Application.LoadLevel (1);

		else if (player2Score == 5)
			Application.LoadLevel (1);

	}

}

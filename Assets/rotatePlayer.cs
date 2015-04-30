using UnityEngine;
using System.Collections;

public class rotatePlayer : MonoBehaviour 
{

	public GameObject Player1, Player2;
	double player1p, player2p;
	double centerPoint;
	void Update()
	{
		//determine player positions
		player1p = Player1.transform.position.x;
		player2p = Player2.transform.position.x;

		//set center point
		centerPoint = Player1.transform.position.x - (player1p - player2p);

		//rotate player
		if(transform.position.x < centerPoint)
			transform.rotation *= Quaternion.Euler(0,  180,  0);
	}

}

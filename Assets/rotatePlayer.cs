using UnityEngine;
using System.Collections;

public class rotatePlayer : MonoBehaviour 
{

	public GameObject Player1, Player2;
	public bool isPlayer1 = true;
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
		if(transform.position.x > centerPoint && isPlayer1)
			transform.rotation *= Quaternion.Euler(0,  180,  0);

		Debug.Log ("center "+centerPoint+" player1 "+player1p+" player2 "+player2p);
		/*else if(transform.position.x > centerPoint && !isPlayer1)
			transform.rotation = Quaternion.Euler(0,  0,  0);

		else if(transform.position.x < centerPoint && isPlayer1)
			transform.rotation = Quaternion.Euler(0,  0,  0);

		else if(transform.position.x < centerPoint && !isPlayer1)
			transform.rotation = Quaternion.Euler(0,  180,  0);*/
	}

}

using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour 
{
	public float colliderSize = 1;
	public int jumps = 0;
	public int maxJumps = 3;
	public int jumpForce = 500;
	public int movementForce = 70;
	public GameObject floor;
	public KeyCode up;
	public KeyCode left;
	public KeyCode right;

	public Animator playerMotionContoller;

	void Update () 
	{
		if (isGrounded())
			jumps = 0;

		//Time.timeScale = 5f;

		if(jumps < maxJumps && Input.GetKeyDown(up))
		{
				GetComponent<Rigidbody2D>().AddForce(Vector3.up * (jumpForce + GetComponent<Rigidbody2D>().velocity.y));
				jumps++;
				playerMotionContoller.SetBool("jump", true);
		}

		if (Input.GetKey(left)) 
		{
			GetComponent<Rigidbody2D>().AddForce(Vector3.left * movementForce);
			playerMotionContoller.SetBool("walk", true);
		}

		else if (Input.GetKey(right)) 
		{
			GetComponent<Rigidbody2D>().AddForce(Vector3.right * movementForce);
			playerMotionContoller.SetBool("walk", true);
		}
		else
		{
			playerMotionContoller.SetBool("walk", false);
		}
	}

	bool isGrounded()
	{
		return (int)(transform.position.y - floor.transform.position.y)  == 1;
	}
}
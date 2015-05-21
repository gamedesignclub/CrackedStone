using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class PlayerMove : MonoBehaviour 
{
	public float colliderSize = 1;
	public int jumps = 0;
	public static int maxJumps = 3;
	public int jumpForce = 500, temp;
	public int movementForce = 70;
	public GameObject floor;
	public KeyCode up;
	public KeyCode left;
	public KeyCode right;

	public Animator playerMotionContoller;
	public Vector3 eulerAngles;

	public AudioClip jump;
	AudioSource audio;
	
	void Start()
	{
		eulerAngles = transform.rotation.eulerAngles;
		temp = jumpForce;
		audio = GetComponent<AudioSource>();
	}


	void Update () 
	{

		if (isGrounded())
			jumps = 0;
		if (GetComponent<Rigidbody2D> ().velocity.y < 0)
			jumpForce += 90 * -((int)GetComponent<Rigidbody2D>().velocity.y);

		Debug.Log ("Force: "+(int)GetComponent<Rigidbody2D> ().velocity.y+" Jump  Force: "+jumpForce);

		if(jumps < maxJumps && Input.GetKeyDown(up))
		{
				audio.PlayOneShot(jump);
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

		//lock the z axis

		eulerAngles = new Vector3(0, eulerAngles.y, eulerAngles.z);
		transform.rotation = Quaternion. Euler(eulerAngles);

		//Set jump back
		jumpForce = temp;
	}

	bool isGrounded()
	{
		return (int)(transform.position.y - floor.transform.position.y)  == 1;
	}
}
using UnityEngine;
using System.Collections;

public class load : MonoBehaviour {

	public void onPress(int a)
	{
		Application.LoadLevel (a);
	}
}
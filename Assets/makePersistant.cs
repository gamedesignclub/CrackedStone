using UnityEngine;
using System.Collections;

public class makePersistant : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
				DontDestroyOnLoad (gameObject);
		}
}

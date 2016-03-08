using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Move : MonoBehaviour {

	private int delay = 0;

	void Start () {
	
	}

	void Update () {
		Debug.Log ("Hei BitBucket!");
		delay++;

		if (delay == 600)
			SceneManager.LoadScene(1);

		print ("delay " + delay);
	
	}
}

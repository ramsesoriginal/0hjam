using UnityEngine;
using System.Collections;

public class Ballremover : MonoBehaviour {

	private BallCreator creator;

	void Start() {
	}

	// Use this for initialization
	void OnCollisionEnter () {
		var g = GameObject.FindGameObjectWithTag ("GameController");
		creator = g.GetComponent<BallCreator>();
		creator.BallColided ();
		Destroy (gameObject);
	}

}

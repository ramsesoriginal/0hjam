using UnityEngine;
using System.Collections;

public class MoveCube : MonoBehaviour {

	void Start() {
		if (GameObject.FindGameObjectWithTag ("GameController")== null)
			Application.LoadLevel("startup scene");
	}

	// Update is called once per frame
	void Update () {
		var p = Input.GetAxis ("Horizontal");
		var x = 0.0f;
		var y = 0.0f;
		if (p < -0.1f) {
			x = -2;
		} else 	if (p > 0.1f) {
			x = 2;
		}
		p = Input.GetAxis ("Vertical");
		if (p < -0.1f) {
			y = -2;
		} else 	if (p > 0.1f) {
			y = 2;
		}
		transform.position=new Vector3(x,0,y);
	}
}

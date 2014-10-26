using UnityEngine;
using System.Collections;

public class LooseGame : MonoBehaviour {

	private StartGame gamemanger;

	void Awake() {
		gamemanger = GameObject.FindGameObjectWithTag("GameController").GetComponent<StartGame>();
	}

	// Use this for initialization
	void OnTriggerEnter () {
		Invoke ("Lost",2);
	}

	void Lost() {
		gamemanger.StartMenu ();
	}

}

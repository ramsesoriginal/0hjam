using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {

	void Awake() {
		DontDestroyOnLoad(gameObject);
	}

	public void StartGameplay () {
		Application.LoadLevel("game");
		gameObject.GetComponent<BallCreator>().resetScore();
	}

	public void StartMenu () {
		Application.LoadLevel("startup scene");
	}
}

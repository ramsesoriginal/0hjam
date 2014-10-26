using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {


	public void StartGameplay () {
		Application.LoadLevel("game");
	}

	public void StartMenu () {
		Application.LoadLevel("startup scene");
	}
}

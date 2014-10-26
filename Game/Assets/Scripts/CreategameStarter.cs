using UnityEngine;
using System.Collections;

public class CreategameStarter : MonoBehaviour {

	public GameObject Startgame;
	public UnityEngine.UI.Button button;

	// Use this for initialization
	void Start () {
		GameObject manager;
		manager = GameObject.FindGameObjectWithTag ("GameController");
		if (manager == null) {
			manager = (GameObject)Instantiate(Startgame,transform.position,transform.rotation);
		}
		button.onClick.AddListener(() => {manager.GetComponent<StartGame>().StartGameplay();});
	}
}

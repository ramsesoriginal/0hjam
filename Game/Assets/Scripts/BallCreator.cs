using UnityEngine;
using System.Collections;

public class BallCreator : MonoBehaviour {

	public int Score;
	public int HighScore;
	public GameObject ball;
	public UnityEngine.UI.Text score;

	
	void Start() {
		resetScore ();
		HighScore = PlayerPrefs.GetInt("highscore", 0);
	}

	public void BallColided() {
		
		Debug.Log ("Hit");
		Score++;
		if (Score > HighScore) {
			HighScore = Score;
			PlayerPrefs.SetInt("highscore", HighScore);
		}
		Debug.Log (Score);
		Instantiate(ball,new Vector3(Random.Range(-1, 1) * 2,4,Random.Range(-1, 1) * 2),new Quaternion());
	}

	void Update() {
		score = GameObject.FindGameObjectWithTag("UI").GetComponent<UnityEngine.UI.Text>();
		Debug.Log (score.text);
		score.text = "Score: " + Score.ToString () + " , HighScore:" + HighScore.ToString ();
	}

	
	public void resetScore() {
		Score = 0;
	}

}

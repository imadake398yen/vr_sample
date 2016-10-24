using UnityEngine;
using System.Collections;

public class GameManager : SingletonMonoBehaviour<GameManager> {

	private int Score;
	public int score {
		get { return Score + 1; }
		set { Score = (value < 100) ? value : 100; }
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

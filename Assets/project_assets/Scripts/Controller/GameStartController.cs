using UnityEngine;
using System.Collections;

public class GameStartController : MonoBehaviour {

	private GameManager gameManager;

	// Use this for initialization
	void Start () {
		gameManager = GameManager.instance;
		gameManager.score = 111;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

#define DEBUG

using UnityEngine;
using System.Collections;


public class GlobalState : MonoBehaviour {
	public enum GameState {MENU, PLAYING};
	public GameState gameState;

	// Use this for initialization
	void Start () {
		Object.DontDestroyOnLoad(this);
		gameState = GameState.MENU;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
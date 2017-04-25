using UnityEngine;
using System.Collections;

public class MenuGUI : MonoBehaviour {

	public GUIStyle buttonStyle;
	public Vector2 buttonSize;
	private GlobalState globalState;

	// Use this for initialization
	void Start () {
		globalState = GameObject.Find ("GlobalState").GetComponent<GlobalState>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI () {
		Vector2 centre = new Vector2(Screen.width/2, Screen.height/2);
		// Make a button. We pass in the GUIStyle defined above as the style to use
		if (GUI.Button (new Rect(centre.x-buttonSize.x/2.0f, centre.y-buttonSize.y/2.0f - 50, buttonSize.x, buttonSize.y), "Play!", buttonStyle)) {
			globalState.gameState = GlobalState.GameState.PLAYING;
			// Application.LoadLevel("Game"); // obsolete
			UnityEngine.SceneManagement.SceneManager.LoadScene ("Game");
		}
	}
}

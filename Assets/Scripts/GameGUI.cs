using UnityEngine;
using System.Collections;

public class GameGUI : MonoBehaviour {
	public Camera mainCamera1;
	public Camera mainCamera2;

	// Use this for initialization
	void Start () {
		mainCamera1.enabled = true;
		mainCamera2.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.LeftShift) || Input.GetKeyDown (KeyCode.RightShift)) {
			mainCamera1.enabled = !mainCamera1.enabled;
			mainCamera2.enabled = !mainCamera2.enabled;
		}
	}
}

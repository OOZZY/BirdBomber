using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
	public float speed;
	public Rigidbody2D bomb;

	// Use this for initialization
	void Start () {
		
	}

	void DropBomb() {
		Vector3 position = new Vector3 (transform.position.x, transform.position.y - 1);
		Instantiate (bomb, position, transform.rotation);
	}

	// Update is called once per frame
	void Update () {
		float velX = Input.GetAxis ("Horizontal") * speed;
		float velY = Input.GetAxis ("Vertical") * speed;
		Vector3 vel = new Vector3 (velX, velY);

		if (velX > 0) {
			GetComponent<SpriteRenderer> ().flipX = true;
		}
		if (velX < 0) {
			GetComponent<SpriteRenderer> ().flipX = false;
		}
		GetComponent<Rigidbody2D> ().MovePosition (transform.position + vel);
		GetComponent<Rigidbody2D> ().MoveRotation (0); // prevent player avatar from rotating

		if (Input.GetKeyDown(KeyCode.Space) && transform.position.y >= 0) {
			DropBomb();
		}
	}
}

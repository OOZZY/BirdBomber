using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {
	public float timeInterval;
	float time;
	public Rigidbody2D enemy;

	const float xmin = -4.5f;
	const float xmax = 4.5f;
	const float ymin = -1.5f;
	const float ymax = 1.5f;
	public float enemySpeed;

	// Use this for initialization
	void Start () {
		time = timeInterval;
	}

	void SpawnEnemy() {
		Vector3 position = new Vector3 ();
		Vector2 velocity = new Vector3 ();
		bool flipX;

		bool leftEdge = Random.Range (0, 100) <= 49;
		if (leftEdge) {
			position.x = xmin;
			position.y = Random.Range (ymin, ymax);
			velocity.x = enemySpeed;
			velocity.y = 0;
			flipX = true;
		} else {
			position.x = xmax;
			position.y = Random.Range (ymin, ymax);
			velocity.x = -enemySpeed;
			velocity.y = 0;
			flipX = false;
		}

		Rigidbody2D enemyClone = (Rigidbody2D)Instantiate (enemy, position, transform.rotation);
		enemyClone.velocity = velocity;
		enemyClone.GetComponent<SpriteRenderer> ().flipX = flipX;
	}
	
	// Update is called once per frame
	void Update () {
		if (time > 0) {
			time -= Time.deltaTime;
		}
		if (time <= 0) {
			SpawnEnemy ();
			time = timeInterval;
		}
	}
}

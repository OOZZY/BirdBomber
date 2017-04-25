using UnityEngine;
using System.Collections;

public class SkyTrigger : MonoBehaviour {
	public AudioSource audioSource;

	void OnTriggerEnter2D(Collider2D other) {
		audioSource.Play ();
		if (other.gameObject.name.Equals ("Bomb(Clone)") ||
				other.gameObject.name.Equals ("Enemy(Clone)")) {
			Destroy (other.gameObject);
		}
	}
}

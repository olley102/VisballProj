using UnityEngine;
using System.Collections;

public class CollidedScript : MonoBehaviour {
	public int collided = 0;

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.name == "Player" || col.gameObject.name == "Ball") {
			collided = 1;
		}
	}
}

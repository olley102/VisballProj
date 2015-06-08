using UnityEngine;
using System.Collections;

public class ControlCamera : MonoBehaviour {
	public float smooth = 1.5f;         // The relative speed at which the camera will catch up.
	public float y;
	public float myy;

	private Transform player;           // Reference to the player's transform.
	private Vector3 newPos;             // The position the camera is trying to reach.

	void Awake () {
		// Setting up the reference.
		player = GameObject.Find("Player").transform;
	}


	void FixedUpdate () {
		myy = transform.position.y;
		myy = myy - 4.0f;
		if (player.position.y - myy > 5 || player.position.y - myy < -5) {
			y = player.position.y;
		}
		newPos = new Vector3(player.position.x, y, player.position.z -9.6f);
		// Lerp the camera's position between its current position and its new position.
		transform.position = Vector3.Lerp(transform.position, newPos, smooth * Time.deltaTime);
		if (player.position.y < -50) {
			GameObject.Find("LevelManager").GetComponent<LevelManager>().LoadLevel("Lose");
		}
	}
}
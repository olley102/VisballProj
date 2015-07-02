using UnityEngine;
using System.Collections;

public class ControlYCam : MonoBehaviour {

	private Transform player;
	float x;
	float z;

	void Awake () {
		player = GameObject.Find("Player").transform;
	}

	void Update () {
		x = player.position.x;
		z = player.position.z;
		transform.position = new Vector3(x, 50, z);
	}
}

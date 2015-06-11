using UnityEngine;
using System.Collections;

public class RotateBlackHole : MonoBehaviour {

	public float speed;

	void Update () {
		transform.Rotate(Vector3.back * Time.deltaTime * speed);
	}
}

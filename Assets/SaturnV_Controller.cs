using UnityEngine;
using System.Collections;

public class SaturnV_Controller : MonoBehaviour {
	void Update () {
		if (transform.position.x < 40) {
			transform.position = Vector3.Lerp (transform.position, new Vector3(40f, 22.18f, 9.42f), Time.deltaTime*0.2f);
		}
		else {
			transform.position = new Vector3(-40.01f, -7.4f, 23.53f);
		}
	}
}

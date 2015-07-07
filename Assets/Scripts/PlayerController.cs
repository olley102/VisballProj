using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 2.0f;
	public float force = 0.0f;
	public float moveHorizontal = 0.0f;
	public float moveVertical = 0.0f;
	
	private Text forcedisp;
	private GameObject joystick;

	void Awake () {
		joystick = GameObject.Find("Joystick");
		GameObject fcount = GameObject.Find("Force Count");
		forcedisp = fcount.GetComponent<Text>();
	}

	void Update () {
		GetComponent<Rigidbody>().velocity = new Vector3(0, GetComponent<Rigidbody>().velocity.y, 0);

		if (joystick.GetComponent<JoystickController>().difx != 0.0f) {
			moveHorizontal = joystick.GetComponent<JoystickController>().difx /20;
		}
		else {
			moveHorizontal = Input.GetAxis("Horizontal");
		}

		if (joystick.GetComponent<JoystickController>().dify != 0.0f) {
			moveVertical = joystick.GetComponent<JoystickController>().dify /20;
		}
		else {
			moveVertical = Input.GetAxis("Vertical");
		}

		Vector3 movement = new Vector3(moveHorizontal*speed, GetComponent<Rigidbody>().velocity.y - 1, moveVertical*speed);
		GetComponent<Rigidbody>().velocity = movement;
		transform.rotation = Quaternion.Euler(0, 0, 0);
	}
	
	void OnCollisionEnter (Collision col) {
		if (col.gameObject.tag == "Tile") {
			GetComponent<Rigidbody>().velocity = new Vector3(moveHorizontal, 20, moveVertical);
		}
		else if (col.gameObject.tag == "Force") {
			Destroy(col.gameObject);
			force = force + 1;
			string forcetxt = "Force: " + force.ToString();
			forcedisp.text = forcetxt;
		}
	}
}

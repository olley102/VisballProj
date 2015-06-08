using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 2.0f;
	public float force = 0.0f;
	public float smooth = 1.5f;
	
	private Text forcedisp;

	void Awake () {
		GameObject fcount = GameObject.Find("Force Count");
		forcedisp = fcount.GetComponent<Text>();
	}

	void Update () {
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		Vector3 movement = new Vector3(moveHorizontal*speed, GetComponent<Rigidbody>().velocity.y - 1, moveVertical*speed);
		GetComponent<Rigidbody>().velocity = movement;
		transform.rotation = Quaternion.Euler(0,0,0);
	}
	
	void OnCollisionEnter (Collision col) {
		if (col.gameObject.tag == "Tile") {
			GetComponent<Rigidbody>().velocity = new Vector3(0, 20, 0);
		}
		else if (col.gameObject.tag == "Force") {
			Destroy(col.gameObject);
			force = force + 1;
			string forcetxt = "Force: " + force.ToString();
			forcedisp.text = forcetxt;
		}
	}
}

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class IncrementLevel : MonoBehaviour {
	private Text txt;
	private GameObject delta;
	public float lvl = 1.0f;
	float extra = 0.0f;

	void Awake() {
		txt = GameObject.Find("Level Count").GetComponent<Text>();
		delta = GameObject.Find("Time Count");
	}

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.tag == "Slide" && col.gameObject.GetComponent<CollidedScript>().collided == 0) {
			lvl += 1.0f;
			txt.text = "Level: " + lvl.ToString();
			extra = lvl * 10.0f;
			delta.GetComponent<TimeScript>().delta -= extra;
		}
	}
}

using UnityEngine;
using System.Collections;

public class FallScript : MonoBehaviour {

	public int time;

	private int delta;
	private Vector3 newPos;

	// Use this for initialization
	void Start () {
		time = Random.Range(0, 118);
		newPos = GameObject.Find("Cylinder").GetComponent<Transform>().position;
	}
	
	// Update is called once per frame
	void Update () {
		delta = GameObject.Find("Time Count").GetComponent<TimeScript>().time;

		if (delta == time) {
			transform.position = Vector3.Lerp(transform.position, newPos, Time.deltaTime*0.5f);
			Destroy (gameObject, 1);
		}
	}
}

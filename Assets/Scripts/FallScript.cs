using UnityEngine;
using System.Collections;

public class FallScript : MonoBehaviour {

	public int time;
	public int min;
	public int max;
	public int lvl;

	private int delta;
	private GameObject player;
	private Vector3 newPos;

	// Use this for initialization
	void Awake () {
		time = Random.Range(min, max);
		newPos = GameObject.Find("Cylinder").GetComponent<Transform>().position;
		player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
		delta = GameObject.Find("Time Count").GetComponent<TimeScript>().time;
		if (delta == time && player.GetComponent<IncrementLevel>().lvl == lvl) {
			transform.position = Vector3.Lerp(transform.position, newPos, Time.deltaTime*0.5f);
			Destroy (gameObject, 1);
		}
	}
}

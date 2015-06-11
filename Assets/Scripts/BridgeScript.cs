using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BridgeScript : MonoBehaviour {

	private Text txt;
	public int spawned = 0;
	public GameObject tile;
	public int force;
	private string forces;

	void Awake () {
		txt = GameObject.Find("Force Count").GetComponent<Text>();
		forces = "Force: " + force.ToString();
	}

	void Update () {
		if (txt.text == forces && spawned == 0) {
			Instantiate(tile, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
			spawned = 1;
		}
	}
}

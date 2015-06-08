using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeScript : MonoBehaviour {
	
	public float delta = 0.0f;
	public int time = 120;

	void Update () {
		delta += Time.deltaTime;
		time = 120 - Mathf.FloorToInt(delta);
		GetComponent<Text>().text = "Time: " + time.ToString();
		if (time == 0) {
			GameObject.Find("LevelManager").GetComponent<LevelManager>().LoadLevel("Lose");
		}
	}
}

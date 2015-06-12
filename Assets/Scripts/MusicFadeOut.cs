using UnityEngine;
using System.Collections;

public class MusicFadeOut : MonoBehaviour {

	void fadeOut() {
		StartCoroutine(volUpdate());
	}

	IEnumerator volUpdate() {
		for (float i = 9.0f; i > 0.0f; i--) {
			GetComponent<AudioSource>().volume = i * 0.1f;
			yield return new WaitForSeconds(0.1f);
		}
		GetComponent<AudioSource>().volume = 0.0f;
	}
}

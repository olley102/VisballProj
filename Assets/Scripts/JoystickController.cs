using UnityEngine;
using System.Collections;

public class JoystickController : MonoBehaviour {

	public float x;
	public float y;
	public float difx;
	public float dify;

	void Start() {
		GetComponent<RectTransform>().Translate(0,0,0);
		x = GetComponent<RectTransform>().position.x;
		y = GetComponent<RectTransform>().position.y;
	}

	void Update() {
		if (Input.touchCount > 0) {
			Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
			GetComponent<RectTransform>().position = new Vector3(
				Mathf.Clamp(touchDeltaPosition.x + GetComponent<RectTransform>().position.x, x -30, x +30),
				Mathf.Clamp(touchDeltaPosition.y + GetComponent<RectTransform>().position.y, y -30, y +30),
				0.0f
			);
			difx = GetComponent<RectTransform>().position.x - x;
			dify = GetComponent<RectTransform>().position.y - y;
		}
		else {
			GetComponent<RectTransform>().position = new Vector3(x, y, 0);
			difx = 0.0f;
			dify = 0.0f;
		}
	}
}

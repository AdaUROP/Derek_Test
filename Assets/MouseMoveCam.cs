using UnityEngine;
using System.Collections;

public class MouseMoveCam : MonoBehaviour {
	Camera cam; 

	void Start() {
		cam = (Camera)GetComponent ("Camera");
	}

	// Update is called once per frame
	void Update () {
		cam.transform.Rotate (Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0);
		if (Input.GetKeyDown (KeyCode.W)) {
			cam.transform.Translate (Vector3.forward);
		} else if (Input.GetKeyDown (KeyCode.S)) {
			cam.transform.Translate (Vector3.back);
		}

		if (Input.GetKeyDown (KeyCode.A)) {
			cam.transform.Translate (Vector3.left);
		} else if (Input.GetKeyDown (KeyCode.D)) {
			cam.transform.Translate (Vector3.right);
		}

		Vector3 vu = cam.WorldToViewportPoint (GameObject.Find ("fluttershy").transform.position);
		if (vu.x > 0 && vu.x < 1 && vu.y > 0 && vu.y < 1 && vu.z > 0) {
			GameObject.Find("Audio Source").SendMessage ("script00");
		}

		vu = cam.WorldToViewportPoint (GameObject.Find ("SunShapeBlendTest").transform.position);
		if (vu.x > 0 && vu.x < 1 && vu.y > 0 && vu.y < 1 && vu.z > 0) {
			GameObject.Find ("SunShapeBlendTest").SendMessage ("frown");
		}
		else GameObject.Find ("SunShapeBlendTest").SendMessage ("unfrown");
	}
}

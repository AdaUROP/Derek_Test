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
	}
}

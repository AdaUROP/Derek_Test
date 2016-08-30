using UnityEngine;
using System.Collections;

public class Throw : MonoBehaviour {

	bool held;
	public Camera cam;

	// Use this for initialization
	void Start () {
		held = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (held) {
		
		}
		else {
			if (inView ()) {
				
			}
		}
	}

	public bool withinBounds() {
		return false;
	}

	public bool inView() {
		Vector3 vu = cam.WorldToViewportPoint (this.transform.position);
		return (vu.x > 0 && vu.x < 1 && vu.y > 0 && vu.y < 1 && vu.z > 0);
	}
}

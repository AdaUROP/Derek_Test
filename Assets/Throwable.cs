using UnityEngine;
using System.Collections;

public class Throwable : MonoBehaviour {

	Vector3 one;
	Vector3 two;
	bool grabbed;

	int deltaFrames = 10;
	int counter = 0;

	public Camera cam;
	public float forceMultiplier;

	// Use this for initialization
	void Start () {
		one = new Vector3 ();
		two = new Vector3 ();
		grabbed = false;
	}

	// Update is called once per frame
	void Update () {
		if (grabbed) {

			if (one != null && counter == deltaFrames) two = new Vector3 (one.x, one.y, one.z);

			one = Input.mousePosition;
			one.z = this.transform.position.z - cam.transform.position.z;
			this.transform.position = cam.ScreenToWorldPoint (one);
		} else if (!grabbed) {
			this.transform.GetComponent<Rigidbody> ().AddForce (new Vector3(this.transform.forward.x, this.transform.forward.y, 0) * forceMultiplier);
		}
		if (counter == deltaFrames)
			counter = 0;
		else
			counter++;
	}

	void OnMouseOver() {
		if (Input.anyKeyDown && !grabbed) {
			grabbed = true;
			print ("Yay");
		} else if (Input.anyKeyDown && grabbed) {
			grabbed = false;
			this.transform.forward = two - one;
			this.transform.forward = new Vector3(this.transform.forward.x, this.transform.forward.y, 0);
			print (this.transform.forward);
		}
	}
}

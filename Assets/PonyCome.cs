using UnityEngine;
using System.Collections;

public class PonyCome : MonoBehaviour {
	bool move = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void come() {
		move = true;
	}

	void FixedUpdate() {
		if (move) {
			GameObject.Find ("fluttershy").transform.rotation = Quaternion.LookRotation (-GameObject.Find ("Camera").transform.forward);
			GameObject.Find ("fluttershy").transform.Translate (Vector3.forward);
		}
		if (Vector3.Distance (GameObject.Find ("fluttershy").transform.position, GameObject.Find ("Camera").transform.position) == 1) {
			move = false;
		}
	}
}

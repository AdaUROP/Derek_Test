using UnityEngine;
using System.Collections;

public class PonyCome : MonoBehaviour {
	bool move = false;

    public Camera maincam;
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
			GameObject.Find ("fluttershy").transform.rotation = Quaternion.LookRotation (-maincam.transform.forward);
			GameObject.Find ("fluttershy").transform.Translate (Vector3.forward);
		}
		if (Vector3.Distance (GameObject.Find ("fluttershy").transform.position, maincam.transform.position) == 1) {
			move = false;
		}
	}
}

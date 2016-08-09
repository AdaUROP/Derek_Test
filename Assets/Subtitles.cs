using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using System.Collections;

public class Subtitles : MonoBehaviour {

	bool display = false;

	// Use this for initialization
	void Start () {
		GetComponent<Text> ().text = "";
	}

	void displayScript00() {
		display = true;
	}

	// Update is called once per frame
	void Update () {
		if (display) {
			GetComponent<Text> ().text = "This is Fluttershy, the most introverted pony in all of Equestria.";
			if (!GameObject.Find ("Audio Source").GetComponent<AudioSource> ().isPlaying) {
				display = false;
			}
		} else {
			GetComponent<Text> ().text = "";
		}
	}
}

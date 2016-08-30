using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using System.Collections;

public class Subtitles : MonoBehaviour {

	public bool onOff;

	bool display = false;

	// Use this for initialization
	void Start () {
		GetComponent<TextMesh> ().text = "";
	}

	public void displayScript00() {
		display = true;
	}

	// Update is called once per frame
	void Update () {
		if (onOff) {
			if (display) {
				GetComponent<TextMesh> ().text = "這是柔柔。柔柔是小馬國最羞答答的小馬。";
				if (!GameObject.Find ("Audio Source").GetComponent<AudioSource> ().isPlaying) {
					display = false;
				}
			} else {
				GetComponent<TextMesh> ().text = "";
			}
		}
	}
}

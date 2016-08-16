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

	public void displayScript00() {
		display = true;
	}

	// Update is called once per frame
	void Update () {
		if (display) {
			GetComponent<Text> ().text = "這是柔柔。柔柔是小馬國最羞答答的小馬。";
			if (!GameObject.Find ("Audio Source").GetComponent<AudioSource> ().isPlaying) {
				display = false;
			}
		} else {
			GetComponent<Text> ().text = "";
		}
	}
}

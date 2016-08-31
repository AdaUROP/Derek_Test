using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using System.Collections;

public class DialogueTrigger : MonoBehaviour {
    public GameObject txt;
    public Camera mainCam;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
    }

	public void script00 () {
		if (!GetComponent<AudioSource> ().isPlaying) {
			GetComponent<AudioSource> ().Play ();
			txt.SendMessage("displayScript", new SubtitleParams("這是柔柔。柔柔是小馬國最羞答答的小馬。",(int)( GetComponent<AudioSource>().clip.length * (1f/Time.deltaTime))));
		}
	}
}

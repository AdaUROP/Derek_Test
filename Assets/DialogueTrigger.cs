﻿using UnityEngine;
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


        Vector3 vu = mainCam.WorldToViewportPoint(GameObject.Find("fluttershy").transform.position);
        Debug.Log(vu);
        if (vu.x > 0 && vu.x < 1 && vu.y > 0 && vu.y < 1 && vu.z > 0)
        {
            GameObject.Find("Audio Source").SendMessage("script00");
        }
    }

	public void script00 () {
		if (!GetComponent<AudioSource> ().isPlaying) {
			GetComponent<AudioSource> ().Play ();
			print ("sending");
            //GameObject.Find ("Text").GetComponent<Text> ().SendMessage ("displayScript00");
            txt.GetComponent<Text>().SendMessage("displayScript00");
		}
	}
}

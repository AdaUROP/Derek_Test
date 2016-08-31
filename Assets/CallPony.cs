using UnityEngine;
using System.Collections;

public class CallPony : MonoBehaviour {

	// public GameObject wand = null;
	public GameObject pony;

	// Use this for initialization
	void Start () {
		pony = GameObject.Find ("fluttershy");
	}
	
	// Update is called once per frame
	void Update () {
		//SteamVR_TrackedObject tObj = wand.GetComponent<SteamVR_TrackedObject> ();

		SteamVR_Controller.Device d = null;
		/*
		if (tObj != null) {
			d = SteamVR_Controller.Input ((int)tObj.index) != null ? SteamVR_Controller.Input ((int)tObj.index) : null;
		}
		*/
		/*
		if ((d != null) ? d.GetPress (SteamVR_Controller.ButtonMask.Trigger) : Input.GetKeyDown(KeyCode.S)) {
			print("sending");
			pony.SendMessage ("come");
		}
		*/

		if (Input.GetKeyDown(KeyCode.Space)) {
			pony.SendMessage ("come");
		}
	}
}

using UnityEngine;
using System.Collections;

public class SunFrown : MonoBehaviour {

	bool frowning = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (!frowning && GameObject.Find ("sunFace").GetComponent<SkinnedMeshRenderer> ().GetBlendShapeWeight (0) > 0) {
			GameObject.Find ("sunFace").GetComponent<SkinnedMeshRenderer> ().SetBlendShapeWeight (0, GameObject.Find ("sunFace").GetComponent<SkinnedMeshRenderer> ().GetBlendShapeWeight (0) - 1);
		}
		else if (frowning && GameObject.Find ("sunFace").GetComponent<SkinnedMeshRenderer> ().GetBlendShapeWeight (0) < 100) {
			GameObject.Find ("sunFace").GetComponent<SkinnedMeshRenderer> ().SetBlendShapeWeight (0, GameObject.Find ("sunFace").GetComponent<SkinnedMeshRenderer> ().GetBlendShapeWeight (0) + 1);
		}
	}

	public void frown() {
		frowning = true;
	}

	public void unfrown() {
		frowning = false;
	}
}

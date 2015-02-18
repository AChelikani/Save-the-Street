using UnityEngine;
using System.Collections;

public class Advance : MonoBehaviour {
	
	void OnCollisionEnter(Collision hit) {
		if (hit.gameObject.tag == "bullet") {
			Application.LoadLevel("DemoScene");
		}
	}
}

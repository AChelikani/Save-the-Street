using UnityEngine;
using System.Collections;

public class bulletCollision : MonoBehaviour {
	void OnCollisionEnter(Collision hit) {
		if (hit.gameObject.tag == "enemy") {
		Destroy (hit.gameObject);
		}
	}
}

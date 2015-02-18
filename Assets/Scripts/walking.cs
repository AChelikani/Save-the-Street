using UnityEngine;
using System.Collections;

public class walking : MonoBehaviour {
	private CardboardHead head;
	private Vector3 startingPosition;

	void Start() {
		head = Camera.main.GetComponent<StereoController>().Head;
		startingPosition = transform.localPosition;
	}

	void Update() {
		RaycastHit hit;
		bool isLookedAt = GetComponent<Collider>().Raycast(head.Gaze, out hit, Mathf.Infinity);
	}
}

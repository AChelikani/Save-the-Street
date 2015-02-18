using UnityEngine;
using System.Collections;

public class health : MonoBehaviour {
	
	public float hitPoints = 100f;
	public float bulletDamage = 10f;

	public void removeHealth(float damage) {
		hitPoints -= damage;
	}

	void OnCollisionEnter(Collision hit) {
		if (hit.gameObject.tag == "bullet") {
			removeHealth (bulletDamage); // bullet does 5 damage
		}
		if (hitPoints <= 0) {
			Destroy(gameObject);
		}
	}
}

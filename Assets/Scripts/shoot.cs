using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour
{
	public Rigidbody projectile;
	public float speed = 20;

	// Update is called once per frame
	void Update ()
	{
		if (Cardboard.SDK.CardboardTriggered)
		{
			Debug.Log("test");
			Rigidbody instantiatedProjectile = Instantiate(projectile,transform.position,transform.rotation)as Rigidbody;
			instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(speed, 0, 0));
		}

	}
	
}﻿
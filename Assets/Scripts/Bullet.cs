﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	// Members
	public float moveSpeed = 7.0f;

	private float timePassed = 0.0f;
    private float damage = 1.0f;
    private GameObject triggerEnemy;

	// Functions
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
		timePassed += 1 * Time.deltaTime;
		if(timePassed >= 5)
		{
			Destroy(this.gameObject);
		}
	}
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            triggerEnemy = other.gameObject;
            triggerEnemy.GetComponent<Enemy>().health -= damage;
            Destroy(this.gameObject);
        }
    }
}

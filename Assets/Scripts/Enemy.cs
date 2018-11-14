using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float health = 1.0f;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(health <= 0)
        {
            Die();
        }
	}

    void Die()
    {
        Destroy(this.gameObject);
    }
}

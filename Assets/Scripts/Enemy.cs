using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float health = 1.0f;
    public float pointsGiven = 1.0f;
    public float moveSpeed = 2.0f;

    private float passedTime = 0.0f;
    private GameObject player;

	// Use this for initialization
	void Start ()
    {
        player = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.LookAt(player.transform);
        passedTime += 1 * Time.deltaTime;
        if(passedTime >= 1)
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
		if(health <= 0)
        {
            Die();
        }
	}

    void Die()
    {
        player.GetComponent<Player>().score += pointsGiven;
        Destroy(this.gameObject);
    }
}

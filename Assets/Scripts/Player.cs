using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    // members or variables
    public float moveSpeed = 7.0f;

    // methods or functions
	
	// Update is called once per frame
	void Update () {
		// Player movement
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
	}
}

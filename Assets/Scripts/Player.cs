using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    // members or variables
    public float health = 3.0f;
    public float moveSpeed = 7.0f;
    public float score = 0.0f;

    public GameObject bulletSpawner;
    public GameObject bullet;

    private Vector3 position;

    // methods or functions
    void Start()
    {
        position = gameObject.transform.position; 
    }
    // Update is called once per frame
    void Update () {
		// Player movement
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            if (Input.GetKeyDown(KeyCode.W))
                transform.GetChild(0).rotation = Quaternion.Euler(0, 0, 0);
            //transform.GetChild(0).LookAt()
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
            if (Input.GetKeyDown(KeyCode.A))
                transform.GetChild(0).rotation = Quaternion.Euler(0, -90, 0);
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
            if (Input.GetKeyDown(KeyCode.S))
                transform.GetChild(0).rotation = Quaternion.Euler(0, 180, 0);
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
            if (Input.GetKeyDown(KeyCode.D))
                transform.GetChild(0).rotation = Quaternion.Euler(0, 90, 0);
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            Shoot();
        }
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            health -= 1.0f;
            transform.position = position;
            /*transform.Translate(position, Space.World);*/
            if(health < 0)
            {
                print("Player died!");
                // Destroy(this.gameObject);
            }
        }
    }
    void Shoot(){
        Instantiate(bullet.transform, bulletSpawner.transform.position, bulletSpawner.transform.rotation);
    }
}

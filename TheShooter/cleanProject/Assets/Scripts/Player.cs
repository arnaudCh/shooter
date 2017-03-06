using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Vector3 playerPosition;
    public float speed = 0.15f;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Move();
    }

    void Move()
    {

        playerPosition.x += Input.GetAxis("Horizontal") * speed;
        playerPosition.z += Input.GetAxis("Vertical") * speed;

        transform.position = playerPosition;

        Debug.Log("Horizontal " + Input.mousePosition);
    }
}

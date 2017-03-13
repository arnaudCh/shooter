using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private Vector3 playerPosition;
    public float    speed = 0.15f;

    public Plane    playerPlane;
    public Ray      ray;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Move();
        Rotation();
    }

    private void Move()
    {
        //transform.Translate(transform.right * Input.GetAxis("Horizontal") * speed);
        //transform.Translate(transform.forward * Input.GetAxis("Vertical") * speed);
        
        transform.Translate(Input.GetAxis("Horizontal") * speed, 0, Input.GetAxis("Vertical") * speed, Space.World);
    }

    private void Rotation()
    {
        playerPlane = new Plane(Vector3.up, transform.position);
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float hitdist;

        if (playerPlane.Raycast(ray, out hitdist))
        {
            Vector3 targetPoint = ray.GetPoint(hitdist);
            Quaternion targetRotation = Quaternion.LookRotation(targetPoint - transform.position);

            transform.rotation = targetRotation;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckMover : MonoBehaviour
{

    public float speed = 1;
    private Rigidbody rb;

	// Use this for initialization
	void Start ()
	{
	    rb = GetComponent<Rigidbody>();
	    rb.velocity = Vector3.forward * speed;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter (Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerController>().Respawn();
            Destroy(this.gameObject);

        }
    }
}
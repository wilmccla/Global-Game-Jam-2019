using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    private Rigidbody rb;
    public bool isGrounded;
    public float jumpHeight = 7f;

	// Use this for initialization
	void Start ()
	{
	    rb = GetComponent<Rigidbody>();
	}

    void OnCollisionStay()
    {
        isGrounded = true;
    }
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
	    {
            rb.AddForce(new Vector3(0, jumpHeight, 0), ForceMode.Impulse);
	    }
	}
}

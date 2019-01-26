using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;
    private Rigidbody rb;
    public float mouseSensitivity;
    public float height;
    public float sprintSpeed;
    public bool ifCrouched;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        height = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        if (moveHorizontal != 0)
        {
            rb.MovePosition(transform.position + transform.right * moveHorizontal * speed * Time.deltaTime);
        }

        if (moveVertical != 0)
        {
            rb.MovePosition(transform.position + transform.forward * moveVertical * speed * Time.deltaTime);
        }

        float mouseInput = Input.GetAxis("Mouse X");
        Vector3 lookhere = new Vector3(0, mouseInput, 0);
        transform.Rotate(lookhere);

        //rb.AddForce(movement * speed);

        /*Crouch
        ifCrouched = (Input.GetKeyDown(KeyCode.LeftControl));

        height = height - 1;
        transform.position = new Vector3(transform.position.x, height, transform.position.z);
        */
    }
}
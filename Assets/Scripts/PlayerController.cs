using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float speed;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        if (moveHorizontal != 0)
        {
            rb.MovePosition(transform.position + transform.right * moveHorizontal * speed * Time.deltaTime);
        }
<<<<<<< HEAD

        if (moveVertical != 0)
        {
            rb.MovePosition(transform.position + transform.forward * moveVertical * speed * Time.deltaTime);
        }

        float mouseInput = Input.GetAxis("Mouse X");
        Vector3 lookhere = new Vector3(0, mouseInput, 0);
        transform.Rotate(lookhere);

=======

        if (moveVertical != 0)
        {
            rb.MovePosition(transform.position + transform.forward * moveVertical * speed * Time.deltaTime);
        }

        float mouseInput = Input.GetAxis("Mouse X");
        Vector3 lookhere = new Vector3(0, mouseInput, 0);
        transform.Rotate(lookhere);

>>>>>>> 78d30d513ca0d3092c7b6f4a813225b6f0466a99
        //rb.AddForce(movement * speed);

        /*Crouch
        ifCrouched = (Input.GetKeyDown(KeyCode.LeftControl));

        height = height - 1;
        transform.position = new Vector3(transform.position.x, height, transform.position.z);
        */
    }
}
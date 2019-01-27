using System.Collections;
using System.Collections.Generic;
using Boo.Lang;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 6;
    private Rigidbody rb;
    public float mouseSensitivity;
    public float height;
    public float sprintSpeed;

    public float resetSpeed;
    //pushing object variable
    public float pushPower = 2.0f;

    // Jumping Variables
    public bool isGrounded;
    public float jumpForce = 3f;
    public Vector3 jump;

    private bool isRunning = false;

    Animator anim;

    public GameObject spawnPoint;

    public bool canMove = true;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        height = transform.position.y;
        jump = new Vector3(0f, 2f, 0f);
        resetSpeed = speed;
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }

        Debug.Log(other.gameObject.tag);
    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            Respawn();
        }
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 hMovement = Vector3.zero;
        Vector3 vMovement = Vector3.zero;
        if (horizontalInput != 0)
        {
            hMovement = transform.right * horizontalInput * speed * Time.deltaTime;
        }

        if (verticalInput != 0)
        {
            vMovement = transform.forward * verticalInput * speed * Time.deltaTime;
        }
        if (canMove)
        {
            //Running Animation
            anim.SetBool("running", (verticalInput > 0));
            //Movement
            rb.MovePosition(transform.position + hMovement + vMovement);
        }

        float mouseInput = Input.GetAxis("Mouse X") * Time.deltaTime * mouseSensitivity;
        Vector3 lookhere = new Vector3(0, mouseInput, 0);
        transform.Rotate(lookhere);

        //Jumping controller
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
        }

        //rb.AddForce(movement * speed);

        /*Crouch
        ifCrouched = (Input.GetKeyDown(KeyCode.LeftControl));
 
        height = height - 1;
        transform.position = new Vector3(transform.position.x, height, transform.position.z);
        */

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = sprintSpeed;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = resetSpeed;
        }
    }

    void FixedUpdate()
    //For Jumping
    {

    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody body = hit.collider.attachedRigidbody;

        if (body == null || body.isKinematic)
        {
            return;
        }

        if (hit.moveDirection.y < -0.3f)
        {
            return;
        }

        Vector3 pushDir = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);

        body.velocity = pushDir * pushPower;
    }

    public void Respawn()
    {
        transform.position = spawnPoint.transform.position;
        transform.rotation = spawnPoint.transform.rotation;
    }
    public void SetSpawn(GameObject point)
    {
        spawnPoint = point;
    }

    public void Pause()
    {
        canMove = true;
        Camera.main.gameObject.GetComponent<CameraController>().enabled = false;
    }


}
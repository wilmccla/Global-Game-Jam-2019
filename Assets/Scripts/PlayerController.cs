using System.Collections;
using System.Collections.Generic;
using Boo.Lang;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;
    private Rigidbody rb;
    public float mouseSensitivity;
    public float height;
    public float sprintSpeed;
    public bool ifCrouched;

    //pushing object variable
    public float pushPower = 2.0f;

    // Jumping Variables
    public bool isGrounded;
    public float jumpHeight = 7f;

    

    public GameObject spawnPoint;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        height = transform.position.y;
    }

    void OnCollisionStay()
    {
        isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1)){
            Respawn();
        }
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

        //Jumping controller
        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {
            rb.AddForce(new Vector3(0, jumpHeight, 0), ForceMode.Impulse);
            isGrounded = false;
        }

        //rb.AddForce(movement * speed);

        /*Crouch
        ifCrouched = (Input.GetKeyDown(KeyCode.LeftControl));

        height = height - 1;
        transform.position = new Vector3(transform.position.x, height, transform.position.z);
        */




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

        Vector3 pushDir =  new Vector3 (hit.moveDirection.x, 0, hit.moveDirection.z);

        body.velocity = pushDir * pushPower;
    }

    public void Respawn(){
        transform.position = spawnPoint.transform.position;
        transform.rotation = spawnPoint.transform.rotation;
    }
    public void SetSpawn(GameObject point){
        spawnPoint = point;
    }


}
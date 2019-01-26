using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float speedHorizontal = 2f;
    public float speedVertical = 2f;

    private float yaw = 0f;
    private float pitch = 0f;

	// Use this for initialization
	void Start () {

	    Cursor.visible = false;
	    Cursor.lockState = CursorLockMode.Locked;

    }
	
	// Update is called once per frame
	void Update ()
	{

	    yaw += speedHorizontal * Input.GetAxis("Mouse X");
	    pitch -= speedVertical * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch, yaw, 0f);

	}
}

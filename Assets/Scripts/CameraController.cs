using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    public float rotateSpeed = 5f;

 public float minimumX = -90F;
 public float maximumX = 90F;
 float rotationX = 0f;

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        rotationX += Input.GetAxis ("Mouse Y") * rotateSpeed * -1;
        rotationX = Mathf.Clamp (rotationX, minimumX, maximumX);

        transform.localEulerAngles = new Vector3 (rotationX, transform.localEulerAngles.y, 0);
    }
}

using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    public float speed;

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        float mouseInput = Input.GetAxis("Mouse Y");
        Vector3 lookhere = new Vector3(mouseInput * speed * -1, 0, 0);
        transform.Rotate(lookhere);
    }
}
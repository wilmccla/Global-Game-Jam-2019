<<<<<<< HEAD
﻿
using UnityEngine;
=======
﻿using UnityEngine;
>>>>>>> 78d30d513ca0d3092c7b6f4a813225b6f0466a99
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
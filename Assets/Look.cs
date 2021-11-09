using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{
    public GameObject camera;

    public float speed = 3.0f;

    void Start()
    {
        Cursor.visible = false;
    }


    void Update()
    {
        transform.Rotate(new Vector3(0, Input.GetAxisRaw("Mouse X") * speed));
        camera.transform.Rotate(new Vector3(-Input.GetAxisRaw("Mouse Y") * speed, 0));
    }
}

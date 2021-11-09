using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;

    void Start()
    {
        
    }


    void Update()
    {
        transform.position += transform.forward * Input.GetAxisRaw("Vertical") * speed;
        transform.position += transform.right * Input.GetAxisRaw("Horizontal") * speed;
    }
}

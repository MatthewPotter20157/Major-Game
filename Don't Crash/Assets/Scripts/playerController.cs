using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerController : MonoBehaviour
{
    public Rigidbody rb;
    public Transform car;
    public float speed = 37;


    Vector3 rotationRight = new Vector3(0, 190, 0);
    Vector3 rotationLeft = new Vector3(0, -190, 0);

    Vector3 forward = new Vector3(0, 0, 1);
    Vector3 backward = new Vector3(0, 0, -1);
    void Update()
    {
        Move();
        
    }

    void Move()
    {
        //move forward
        if (Input.GetKey("w"))
        {
            transform.Translate(forward * speed * Time.deltaTime, Space.World);
        }
        //move backwards
        if (Input.GetKey("s"))
        {
            transform.Translate(backward * speed * Time.deltaTime);
        }
        //move right
        if (Input.GetKey("d"))
        {

            transform.Translate(Vector3.right * speed * Time.deltaTime, Space.World);
        }
        //move left
        if (Input.GetKey("a"))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
        }

    }
}

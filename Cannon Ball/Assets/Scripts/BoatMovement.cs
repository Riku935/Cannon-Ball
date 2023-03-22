using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class BoatMovement : MonoBehaviour
{
    public float speed;
    public float turnSpeed;

    public float angleRotate;
    private Rigidbody rb;
    private float velocityMagnitude;
 
    
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //rb.AddTorque(0f, h * turnSpeed, 0f);    
        rb.AddTorque(0, Rotation(), 0);
        rb.AddForce(transform.forward * v * speed);

 
        //velocityMagnitude = rb.velocity.magnitude;
        //rb.velocity = transform.forward * velocityMagnitude; 
    }
    private float Rotation()
    {
        angleRotate = Input.GetAxis("Horizontal") * turnSpeed;
        return angleRotate;
    }
}

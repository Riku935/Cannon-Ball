using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootProjectile : MonoBehaviour
{
    public Transform launchPointRight;
    public Transform launchPointLeft;
    public GameObject cannonBall;
    public float launchVelocity = 20f;
    Rigidbody rb;
    public float thrust = 20f;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (Input.GetButtonDown("Fire1") && GameManager.obj.gameReady == true)
        {
            var projectile = Instantiate(cannonBall, launchPointRight.position, launchPointRight.rotation);
            projectile.GetComponent<Rigidbody>().velocity = launchPointRight.up * launchVelocity;
            rb.AddForce(transform.right * thrust);
            AudioManager.obj.playShot();
        }
        if (Input.GetButtonDown("Fire2") && GameManager.obj.gameReady == true)
        {
            var projectile = Instantiate(cannonBall, launchPointLeft.position, launchPointLeft.rotation);
            projectile.GetComponent<Rigidbody>().velocity = launchPointLeft.forward * launchVelocity;
            rb.AddForce(-transform.right * thrust);
            AudioManager.obj.playShot();

        }
    }
}

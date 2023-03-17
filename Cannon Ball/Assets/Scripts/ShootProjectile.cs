using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootProjectile : MonoBehaviour
{
    public Transform launchPoint;
    public GameObject cannonBall;
    public float launchVelocity = 20f;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            var projectile = Instantiate(cannonBall, launchPoint.position, launchPoint.rotation);
            projectile.GetComponent<Rigidbody>().velocity = launchPoint.up * launchVelocity;
        }
    }
}

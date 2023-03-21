using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatLife : MonoBehaviour
{
    private int _boatLife = 5;
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            _boatLife--;
        }
    }
    private void BoatDeath()
    {
        if(_boatLife <= 0)
        {
            gameObject.SetActive(false);
            GameManager.obj.endGame++;
        }
    }
    void Update()
    {
        BoatDeath();
    }
}

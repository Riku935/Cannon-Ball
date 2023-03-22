using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBall : MonoBehaviour
{
    public float fieldOfImpact;
    public float explosionForce;
    public GameObject explosion;


    private void Awake()
    {
        Destroy(gameObject, 5f);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Explosion();
        Destroy(gameObject);
        AudioManager.obj.playHit();
    }
    void Explosion()
    {
        GameObject _explosion = Instantiate(explosion, transform.position, transform.rotation);
        Collider[] _colliders = Physics.OverlapSphere(transform.position, fieldOfImpact);
        foreach (Collider target in _colliders)
        {
            Rigidbody rb = target.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(explosionForce, transform.position, fieldOfImpact);
            }
        }
        Destroy(_explosion, 3f);

    }
}

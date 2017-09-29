using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

    public float radius = 5;
    public float[] powerRange = new float[2];
    public float upForce = 1;

    private Vector3 explosionPosition;
    private Collider[] parts;
    private Rigidbody rb;
    private bool activated;

    private void Awake()
    {
        explosionPosition = transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!activated && other.CompareTag("Player"))
        {
            Debug.Log("Player inside");
            activated = true;
            Detonation();
        }
    }

    private void Detonation()
    {
        Debug.Log("Detonating");
        parts = Physics.OverlapSphere(explosionPosition, radius);
        foreach(Collider hit in parts)
        {
            rb = hit.GetComponent<Rigidbody>();
            if (rb != null)
            {
                float power = Random.Range(powerRange[0], powerRange[1]);
                Debug.Log(power);
                rb.AddExplosionForce(power, explosionPosition, radius, upForce, ForceMode.Impulse);
            }
        }
    }

}

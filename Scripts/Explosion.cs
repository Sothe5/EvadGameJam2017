using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{

    public float radius = 5;
    public float[] powerRange = new float[2];
    public float upForce = 1;
    public GameObject parts;
    public GameObject particleSystem;

    private Vector3 explosionPosition;
    private Rigidbody rb;
    private bool activated;
    private float power;

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
        foreach(Transform hit in parts.transform)
        {
            rb = hit.gameObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                power = Random.Range(powerRange[0], powerRange[1]);
                Debug.Log(power);
                rb.isKinematic = false;
				rb.AddForce(Vector3.Normalize((this.transform.position - explosionPosition)) * power, ForceMode.Impulse);
            }
        }
		//particleSystem.SetActive (true);
    }

}

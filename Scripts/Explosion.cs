using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

    public float radius = 5;
    public float power = 10;
    public float upForce = 1;

    private Vector3 explosionPosition;
    private Collider[] parts;
    private Rigidbody rb;

    private void Awake()
    {
        explosionPosition = transform.position;
    }

    // Use this for initialization
    void Start () {
        Invoke("Detonation", 1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void Detonation()
    {
        Debug.Log("Detonating");
        parts = Physics.OverlapSphere(explosionPosition, radius);
        foreach(Collider hit in parts)
        {
            rb = hit.GetComponent<Rigidbody>();
            Debug.Log(rb);
            if(rb != null)
                rb.AddExplosionForce(power, explosionPosition, radius, upForce, ForceMode.Impulse);
        }
    }

}

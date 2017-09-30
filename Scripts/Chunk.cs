using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour {
	public float length;

	void Start() {
		BoxCollider collider = GetComponent<BoxCollider> ();
		if (collider) {
			this.length = collider.size.z * this.transform.localScale.z;
		}
	}
}

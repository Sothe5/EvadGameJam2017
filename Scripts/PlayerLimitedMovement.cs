using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLimitedMovement: MonoBehaviour {

	private float StartingPoint;
	// Use this for initialization
	void Start () {
		 StartingPoint = FindObjectOfType<ProceduralGeneration> ().transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
		if (eulerRotation.y < -90) {
			transform.localEulerAngles = new Vector3 (eulerRotation.x, -90, eulerRotation.z);
		} else if (eulerRotation.y > 90) {
			transform.localEulerAngles = new Vector3 (eulerRotation.x, 90, eulerRotation.z);
		}
	}
}

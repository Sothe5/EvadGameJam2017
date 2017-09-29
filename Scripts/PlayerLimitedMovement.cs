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
		transform.position = new Vector3(this.transform.position.x,this.transform.position.y,StartingPoint);
	}
}

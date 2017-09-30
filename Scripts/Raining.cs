using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raining : MonoBehaviour {

    public Animator animator;
    public float timeBetweenFases;

    private float timer;

	// Use this for initialization
	void Start () {
        animator.SetInteger("inicio", Random.Range(1,4));
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if(timer >= timeBetweenFases)
        {
            int random = Random.Range(1, 4);
            animator.SetInteger("inicio", random);
            Debug.Log("Random: " + random);
            timer = 0;
        }
	}
}

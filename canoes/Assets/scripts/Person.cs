using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour {
	Rigidbody canoe;
	public float forwardForce, sideForce;

	void Awake(){
		canoe = transform.parent.GetComponent<Rigidbody> ();
	}

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		int side = 0;

		if (Input.GetKeyDown (KeyCode.LeftArrow))
			--side;
		if (Input.GetKeyDown (KeyCode.RightArrow))
			++side;

		if (side != 0)
			Paddle (side);
	}

	void Paddle(int dir){
		canoe.AddForceAtPosition (transform.forward * forwardForce, transform.position + transform.right * dir * 2f);
	}
}

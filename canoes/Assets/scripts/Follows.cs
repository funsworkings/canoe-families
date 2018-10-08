using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follows : MonoBehaviour {
	public Transform target;
	public bool isOffset;


	Vector3 offset;

	// Use this for initialization
	void Start () {
		if (target != null && isOffset)
			CalculateOffset ();
	}
	
	// Update is called once per frame
	void Update () {
		if (isOffset)
			transform.position = target.position + offset;
		else
			transform.position = target.position;
	}

	void CalculateOffset(){
		offset = (transform.position - target.position);
	}
}

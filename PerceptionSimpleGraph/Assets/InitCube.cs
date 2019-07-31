using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitCube : MonoBehaviour {

	public float s;
	public float c;

	// Use this for initialization
	void Awake () {
		s = Random.Range(0.1f,2.0f);
		this.transform.localScale *= s;
		c = Random.Range(0.0f, 1.0f);

		this.GetComponent<Renderer>().material.color = new Color(0,0,c);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

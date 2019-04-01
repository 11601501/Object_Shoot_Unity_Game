using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	public int delta,speed;
	public Vector2 startpos;
	// Use this for initialization
	void Start () {
		startpos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 v = startpos;
		v.x += delta * Mathf.Sin (Time.time * speed);
		transform.position = v;
	}
}

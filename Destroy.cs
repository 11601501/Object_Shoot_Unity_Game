using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {
	public GameObject obj1;

	objspawn ins;
	// Use this for initialization
	void Start () {
		ins = GameObject.FindGameObjectWithTag ("Player").GetComponent<objspawn> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown()
	{
		ins.SendMessage ("IncScore");
		Destroy (obj1);
	}
	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.name == "Panel") {
		
			ins.SendMessage ("DecScore");
			Destroy (obj1);
		}
	}

}

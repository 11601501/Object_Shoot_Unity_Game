using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class objspawn : MonoBehaviour {

	public GameObject[] myarray;
	public int score;
	public Text myscore;
	// Use this for initialization
	void Start () {
		Invoke ("CreateObject", 0.5f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void CreateObject()
	{
		Instantiate (myarray [Random.Range (0, 2)], transform.position, transform.rotation);
		Start ();
	}

	public void IncScore()
	{
		score = score + 1;
		myscore.text = score.ToString ();
	}


	public void DecScore()
	{
		if (score > 0) {
			score = score - 1;
			myscore.text = score.ToString ();
		
		}
	}




}




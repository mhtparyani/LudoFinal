using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedMoveDetection : MonoBehaviour {



	private float decreasingValuex;
	private float increaseValuez;

	Vector3 sizenew;

	string myName;

	// Use this for initialization
	void Start () {
		myName = this.gameObject.name;
		sizenew = new Vector3 (0.02f, 0.02f, 0.02f);
		decreasingValuex = 0.3f;
		increaseValuez = 1.0f;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision c){
		Debug.Log (c.gameObject.name);
		if (c.gameObject.name.Contains("_Blue")) {
			
			//Vector3 rpos = transform.position;
			//rpos.y=transform.position.y + increaseValuez;
			//this.GetComponent<SB> ().pos = rpos;
			transform.localScale=sizenew;

		}
		if (c.gameObject.name.Contains("_Red")) {
			transform.localScale = sizenew;
		}
		if (c.gameObject.name.Contains("_Green")) {
			
		//	Vector3 rpos = transform.position;
		//	rpos.y=transform.position.y + increaseValuez;
		//	this.GetComponent<SB> ().pos = rpos;
			transform.localScale=sizenew;
		}

		if (c.gameObject.name.Contains("_Yellow")) {

		//	Vector3 rpos = transform.position;
		//	rpos.y=transform.position.y + increaseValuez;
		//	this.GetComponent<SB> ().pos = rpos;
			transform.localScale=sizenew;
		}
	}
}

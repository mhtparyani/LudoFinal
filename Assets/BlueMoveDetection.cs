using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueMoveDetection : MonoBehaviour {
	
	Vector3 sizenew;
	private float increasingValuex;
	private float increaseValuez;
	// Use this for initialization
	void Start () {
		sizenew = new Vector3 (0.02f, 0.02f, 0.02f);
		increasingValuex = 0.05f;
		increaseValuez = 0.3f;
	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision c){
		
		if (c.gameObject.name.Contains("_Red")) {
			
			transform.localScale=sizenew;
		//	Vector3 bpos = transform.position;
		//	bpos.y=transform.position.y + increaseValuez;
		//	this.GetComponent<SB> ().pos = bpos;
		}

		if (c.gameObject.name.Contains("_Blue")) {

			transform.localScale=sizenew;
		//	Vector3 bpos = transform.position;
		//	this.GetComponent<SB> ().yposition=transform.position.y + increaseValuez;
			//this.GetComponent<SB> ().pos = bpos;
		}
		if (c.gameObject.name.Contains("_Green")) {
			transform.localScale=sizenew;
		//	Vector3 pos = transform.position;
		//	pos.y=transform.position.y + increaseValuez;
		//	this.GetComponent<SB> ().pos = pos;
		}

		if (c.gameObject.name.Contains("_Yellow")) {
			transform.localScale=sizenew;
		//	Vector3 pos = transform.position;
		//	pos.y=transform.position.y + increaseValuez;
		//	this.GetComponent<SB> ().pos = pos;
		}
	}
}

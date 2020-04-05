using UnityEngine;
using System.Collections;

public class SG4 : MonoBehaviour {

	public Vector3 pos;
	public int index;
	public string color;
	
	void Start () {
	
		pos=this.transform.position;
		index=-1;
		color="Green";
	}
	
	void Update () {
		this.GetComponent<Rigidbody>().MovePosition(pos);
	}
	
	public void ChangePosition(Vector3 p){
		var y = this.transform.position.y ;
		pos=p;
		pos.y=y;
	}
}

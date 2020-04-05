using UnityEngine;
using System.Collections;

public class SB : MonoBehaviour {


	public Vector3 initialPos;
	public Vector3 pos;
	public int index;
	public bool isPug;
	public GameObject gameObj;
	public string color;

	public bool isChange=false;
	public bool isNextFound=false;
	int currentIndex, nextPosIndex;
	public GameObject step1;
	public GameObject step2;
	public GameObject step3;
	public GameObject step4;
	public GameObject step5;
	public GameObject step6;
	public GameObject step7;
	public GameObject step8;
	public GameObject step9;
	public GameObject step10;
	public GameObject step11;
	public GameObject step12;
	public GameObject step13;
	public GameObject step14;
	public GameObject step15;
	public GameObject step16;
	public GameObject step17;
	public GameObject step18;
	public GameObject step19;
	public GameObject step20;
	public GameObject step21;
	public GameObject step22;
	public GameObject step23;
	public GameObject step24;
	public GameObject step25;
	public GameObject step26;
	public GameObject step27;
	public GameObject step28;
	public GameObject step29;
	public GameObject step30;
	public GameObject step31;
	public GameObject step32;
	public GameObject step33;
	public GameObject step34;
	public GameObject step35;
	public GameObject step36;
	public GameObject step37;
	public GameObject step38;
	public GameObject step39;
	public GameObject step40;
	public GameObject step41;
	public GameObject step42;
	public GameObject step43;
	public GameObject step44;
	public GameObject step45;
	public GameObject step46;
	public GameObject step47;
	public GameObject step48;
	public GameObject step49;
	public GameObject step50;
	public GameObject step51;
	public GameObject step52;
	public GameObject step53;
	public GameObject step54;
	public GameObject step55;
	public GameObject step56;

	public GameObject finalStep1;
	public GameObject finalStep2;
	public GameObject finalStep3;
	public GameObject finalStep4;

	public float yposition;

	ArrayList steps;
	void Start () {
		currentIndex = 0;
		yposition = 0;
		index=-1;
		isPug=false;
		steps = new ArrayList ();
		steps.Add (step1);
		steps.Add (step2);
		steps.Add (step3);
		steps.Add (step4);
		steps.Add (step5);
		steps.Add (step6);
		steps.Add (step7);
		steps.Add (step8);
		steps.Add (step9);
		steps.Add (step10);
		steps.Add (step11);
		steps.Add (step12);
		steps.Add (step13);
		steps.Add (step14);
		steps.Add (step15);
		steps.Add (step16);
		steps.Add (step17);
		steps.Add (step18);
		steps.Add (step19);
		steps.Add (step20);
		steps.Add (step21);
		steps.Add (step22);
		steps.Add (step23);
		steps.Add (step24);
		steps.Add (step25);
		steps.Add (step26);
		steps.Add (step27);
		steps.Add (step28);
		steps.Add (step29);
		steps.Add (step30);
		steps.Add (step31);
		steps.Add (step32);
		steps.Add (step33);
		steps.Add (step34);
		steps.Add (step35);
		steps.Add (step36);
		steps.Add (step37);
		steps.Add (step38);
		steps.Add (step39);
		steps.Add (step40);
		steps.Add (step41);
		steps.Add (step42);
		steps.Add (step43);
		steps.Add (step44);
		steps.Add (step45);
		steps.Add (step46);
		steps.Add (step47);
		steps.Add (step48);
		steps.Add (step49);
		steps.Add (step50);
		steps.Add (step51);
		steps.Add (step52);
		steps.Add (step53);
		steps.Add (step54);
		steps.Add (step55);
		steps.Add (step56);
	}
	

	void Update()
	{

		GetComponent<Rigidbody>().freezeRotation = true;
		pos.y = yposition;
		Vector3 currentPosition = transform.position;
		Vector3 newPosition = Vector3.Lerp(currentPosition, pos, 0.5f);
		//this.GetComponent<Rigidbody>().MovePosition(pos);
		transform.position = newPosition;
	}
	

	void LateUpdate(){
		if (isChange) {
			Debug.Log (currentIndex + "/" + nextPosIndex);
			if (currentIndex.Equals (nextPosIndex)) {
				isChange = false;
				//goto waitForChance;
			} else {
				currentIndex++;
				GameObject nextStep = (GameObject)steps [currentIndex];
				pos = nextStep.transform.position;
			}

			//waitForChance:
			//;
		}
	}
	
	public void ChangePosition(Vector3 p){
//		pos = p;
		Vector3 currentPosition = transform.position;
		//Debug.Log ("position p:" + p);
		for(int i=0;i<steps.Count;i++)
		{
			GameObject step = (GameObject)steps [i];
			//Debug.Log ("step position:" + step.transform.position);
			//if (step.transform.position.x.Equals (currentPosition.x) && step.transform.position.z.Equals (currentPosition.z)) {
			//	currentIndex = i;
			//}

			if (step.transform.position.Equals (p)) {
				yposition = step.transform.position.y + 0.04f;
				nextPosIndex = i;
				isNextFound = true;
				//Debug.Log ("next step position:" + step.transform.position);
				break;
			} else {
				isNextFound = false;
			}
		}
		if (nextPosIndex == 0 || !isNextFound) {
			isChange = false;
			pos = p;
			if (color.Equals ("Red")) {
			}else if (color.Equals ("Blue")) {
			}else if (color.Equals ("Green")) {
			}else if (color.Equals ("Yellow")) {
			}
		} else {
			isChange = true;
			currentIndex++;
			GameObject nextStep =(GameObject) steps [currentIndex];
			pos=nextStep.transform.position;

			if (color.Equals ("Red")) {
			}else if (color.Equals ("Blue")) {
			}else if (color.Equals ("Green")) {
			}else if (color.Equals ("Yellow")) {
			}
		}
	}
	

	public void ResetPosition()
	{
		currentIndex = 0;
		yposition = 0;
		index = -1;
		pos = initialPos;
	}

	public void GoToFinal(){
		if (this.name.Equals ("_Blue1") || this.name.Equals ("_Red1") || this.name.Equals ("_Yellow1") || this.name.Equals ("_Green1")) {
			pos = finalStep1.transform.position;
		} else if (this.name.Equals ("_Blue2") || this.name.Equals ("_Red2") || this.name.Equals ("_Yellow2") || this.name.Equals ("_Green2")) {
			pos = finalStep2.transform.position;
		} else if (this.name.Equals ("_Blue3") || this.name.Equals ("_Red3") || this.name.Equals ("_Yellow3") || this.name.Equals ("_Green3")) {
			pos = finalStep3.transform.position;
		} else if (this.name.Equals ("_Blue4") || this.name.Equals ("_Red4") || this.name.Equals ("_Yellow4") || this.name.Equals ("_Green4")) {
			pos = finalStep4.transform.position;
		}
	}

}

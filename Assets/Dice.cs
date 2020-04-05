using System.Collections;
using UnityEngine;

public class Dice : MonoBehaviour {

    public int finalSide = 0;
	public bool canRoll;
    // Array of dice sides sprites to load from Resources folder
    private Sprite[] diceSides;

	private int noOfSix=0;
    // Reference to sprite renderer to change sprites
    private SpriteRenderer rend;

	// Use this for initialization
	private void Start () {

		canRoll = true;
        // Assign Renderer component
        rend = GetComponent<SpriteRenderer>();

        // Load dice sides sprites to array from DiceSides subfolder of Resources folder
        diceSides = Resources.LoadAll<Sprite>("DiceSides/");
	}
	
    // If you left click over the dice then RollTheDice coroutine is started
    private void OnMouseDown()
    {
		if(canRoll){
			canRoll = false;
			StartCoroutine("RollTheDice");
		}
    }

    // Coroutine that rolls the dice
    private IEnumerator RollTheDice()
    {
        // Variable to contain random dice side number.
        // It needs to be assigned. Let it be 0 initially

		Roll_again:
		;
        int randomDiceSide = 0;

        // Final side or value that dice reads in the end of coroutine
        //int finalSide = 0;

        // Loop to switch dice sides ramdomly
        // before final side appears. 20 itterations here.
        for (int i = 0; i <= 15; i++)
        {
            // Pick up random value from 0 to 5 (All inclusive)
            randomDiceSide = Random.Range(0, 8);

            // Set sprite to upper face of dice from array according to random value
            rend.sprite = diceSides[randomDiceSide];

            // Pause before next itteration
            yield return new WaitForSeconds(0.05f);
        }

        // Assigning final side so you can use this value later in your game
        // for player movement for example
		if (randomDiceSide >= 6) {
			finalSide = 6;
		} else {
			finalSide = randomDiceSide + 1;
		}
		//Debug.Log ("ramdomside: "+randomDiceSide);

		if (finalSide == 6) {
			noOfSix++;
			//Debug.Log ("No Of Six: "+noOfSix);
			if (noOfSix >= 3) {
				//Debug.Log ("Rolling again");
				goto Roll_again;
			}
		} else {
			noOfSix = 0;
		}

		GameObject.Find ("pCube1").GetComponent<Gamer> ().showTheMagic (finalSide);

        // Show final dice value in Console
        //Debug.Log(finalSide);
    }
}

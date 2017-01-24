using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {	
	int max;
	int min;
	int guess;
	// Use this for initialization
	void Start () {
		StartGame();
	}
	void StartGame(){
		max = 1000;
		min = 1;
		guess = 500;
		print("*******************************************************************************");
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head, but don't tell me!");
		
		print ("The highest number you can pick is " + max + " and the lowest is " + min);
		
		print ("Is the number higher or lower than " + guess + "?");
		
		print ("Press the up arrow for higher, the down arrow for lower, return for equals.");
		print("*******************************************************************************");
		
	}

	// Update is called once per frame
	void Update () {
		
		
		if (Input.GetKeyDown("return")){
			print("Your number was " + guess + ", I win!");
			StartGame();
		} else if (Input.GetKeyDown(KeyCode.UpArrow) && guess != 999){
			min = guess;
			guess = (max + min)/2;
			print("Is your number higher lower than " + guess + "?");	
			print ("Press the up arrow for higher, the down arrow for lower, return for equals.");
		} else if (Input.GetKeyDown(KeyCode.DownArrow)){
			max = guess;
			guess = (max + min)/2;
			print("Is your number higher lower than " + guess + "?");	
			print ("Press the up arrow for higher, the down arrow for lower, return for equals.");
		} else if(Input.GetKeyDown(KeyCode.UpArrow) && guess == 999){
			print("Is your number 1000?, press return to confirm.");
			guess = 1000;
				if(Input.GetKeyDown("return")){
				print("I win!");
				StartGame();
				}
		}
			
	}
}

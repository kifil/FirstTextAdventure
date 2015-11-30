using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	//create variables to link unity objects with c# objects
	public Text text;
	private enum States {cell, sheets_0, mirror,lock_0, sheets_1, cell_mirror, lock_1, freedom};
	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if(myState == States.cell){
			state_cell ();
		}else if(myState == States.sheets_0){
			state_sheets_0 ();
		}else if(myState == States.mirror){
			state_mirror ();
		}else if(myState == States.lock_0){
			state_lock_0 ();
		}else if(myState == States.cell_mirror){
			state_cell_mirror ();
		}else if(myState == States.sheets_1){
			state_sheets_1 ();
		}else if(myState == States.lock_1){
			state_lock_1 ();
		}
		
	}
	
	//game start
	void state_cell(){
		text.text = "You wake up trapped in a prison cell. "+
					"After banging on the cell doors for a while it doesn’t seem like anyone is around to hear you. " + 
					"You see some dirty sheets on the bed, a cracked mirror on the wall, and the door which is locked from the outside.\n\n" +
					"Press S to look at the Sheets, M for the Mirror, or L for the door Lock";
		if(Input.GetKeyDown(KeyCode.S)){
			myState = States.sheets_0;
		}else if(Input.GetKeyDown(KeyCode.M)){
			myState = States.mirror;
		}else if(Input.GetKeyDown(KeyCode.L)){
			myState = States.lock_0;
		}
	}
	////////////////////////
	
	//choice set 1
	void state_sheets_0(){
		text.text = "You walk over to the sheets. You see that the raggged sheets barely cover a decaying mattress beneath it. "+
				"Not much else to see here. \n\n" +
				"Press R to Return to your damp cell";
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.cell;
		}
	}
	
	void state_mirror(){
		text.text = "You walk over to the mirror. You see that the mirror is cracked and a small "+
					"piece of it has fallen onto the ground. \n\n"+
					"Press R to Return to your damp cell or press T to carefully take the mirror shard";
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.cell;
		}else if(Input.GetKeyDown(KeyCode.T)){
			myState = States.cell_mirror;
		}
	}
	
	void state_lock_0(){
		text.text = "You walk over to the lock. You see that it is a button combination lock. You try to make out what buttons "+
					"have been pressed before, but the single ceiling light in the room is to dim to make them out. \n\n"+
					"Press R to Return to your damp cell";
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.cell;
		}
	}
	////////////////////
	
	//choice set 2
	void state_cell_mirror(){
		text.text = "With the shard of glass in hand you stand in your cell. You hear a faint dripping "+
					"noise coming from outside your cell. \n\n"+
					"Press S to walk back to the sheets, or L to examine the lock";
			if(Input.GetKeyDown(KeyCode.S)){
				myState = States.sheets_1;
			}else if(Input.GetKeyDown(KeyCode.L)){
				myState = States.lock_1;
			}
	}
	
	void state_sheets_1(){
		text.text = "Using the shard of mirror you reflect the light from the ceiling to get a better look at the sheets. "+
					"All you notice is that they are even more disgusting and ragged than you previously thought. \n\n"+
					"Press R to Return to your damp cell";
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.cell_mirror;
		}
	}
	
	void state_lock_1(){
		text.text = "Using the shard of mirror you reflect the light from the ceiling light to get a better look at the lock. "+
					"You can see that some buttons look cleaner than the others. With some persistence you are able to work "+
					"out the correct code and with a small beep the door opens. \n\n"+
					"Press C to quickly move into the corridor beyond";
		if(Input.GetKeyDown(KeyCode.C)){
			myState = States.freedom;
		}

	}
}

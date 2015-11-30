using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	//create variables to link unity objects with c# objects
	public Text text;
	private enum States {cell, sheets_0, mirror,lock_0, sheets_1, cell_mirror, lock_1, corridor_0,
	stairs_0, floor, closet_door, stairs_1, corridor_1, in_closet, stairs_2, corridor_2, corridor_3, courtyard};
	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		//cell phase
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
		//corridor phase
		}else if(myState == States.corridor_0){
			state_corridor_0 ();
		}else if(myState == States.stairs_0){
			state_stairs_0 ();
		}else if(myState == States.floor){
			state_floor ();
		}else if(myState == States.closet_door){
			state_closet_door ();
		}else if(myState == States.stairs_1){
			state_stairs_1 ();
		}else if(myState == States.corridor_1){
			state_corridor_1 ();
		}else if(myState == States.in_closet){
			state_in_closet ();
		}else if(myState == States.stairs_2){
			state_stairs_2 ();
		}else if(myState == States.corridor_2){
			state_corridor_2 ();
		}else if(myState == States.corridor_3){
			state_corridor_3 ();
		//freedom
		}else if(myState == States.courtyard){
			state_courtyard ();
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
	
	//cell set 1
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
	
	//cell set 2
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
			myState = States.corridor_0;
		}

	}
	////////////////////
	
	//corridor start
	void state_corridor_0(){
		text.text = "You stand in a dimly lit corridor. You see at one of the hall there are stairs leading to an exit door "+
					"and at the other end there is a janitor's closet. "+
					"The floor itself is littered with junk and has several small puddles. \n\n" + 
					"Press S to walk to the Stairs, J for the Janitor's closet, or F to examine the floor";
		if(Input.GetKeyDown(KeyCode.S)){
			myState = States.stairs_0;
		}else if(Input.GetKeyDown(KeyCode.F)){
			myState = States.floor;
		}else if(Input.GetKeyDown(KeyCode.J)){
			myState = States.closet_door;
		}
	}
	////////////////
	
	//corridor set 1
	void state_stairs_0(){
		text.text = "You walk up to the top of the stairs. You try the door, but it's locked. "+
			"You see what looks to be a keycard reader next to it. \n\n"+
				"Press R to Return to the corridor";
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.corridor_0;
		}
	}
	
	void state_closet_door(){
		text.text = "You walk over to the janitor's closet. You try the door, but it's locked. "+
			"This door has a a simple keyhole on the lock. \n\n"+
				"Press R to Return to the corridor";
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.corridor_0;
		}
	}
	
	void state_floor(){
		text.text = "You take a closer look at the floor. "+
			"After sifting through some of the junk you see a bobby pin. \n\n"+
				"Press R to Return to the corridor or press B to take the Bobby pin ";
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.corridor_0;
		}else if(Input.GetKeyDown(KeyCode.B)){
			myState = States.corridor_1;
		}
	}
	////////////////
	
	//corridor set 2
	
	void state_stairs_1(){
		text.text = "You walk up to the top of the stairs. You try the door, but it's locked. "+
			"You see what looks to be a keycard reader next to it. \n\n"+
				"Press R to Return to the corridor";
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.corridor_1;
		}
	}
	
	void state_corridor_1(){
		text.text = "You stand in a dimly lit corridor holding the bobby pin. You see at one of the hall there are stairs leading to an exit door "+
					"and at the other end there is a janitor's closet. \n\n"+
					"Press S to walk to the Stairs or P to pick the janitor's closet door";
		if(Input.GetKeyDown(KeyCode.S)){
			myState = States.stairs_1;
		}else if(Input.GetKeyDown(KeyCode.P)){
			myState = States.in_closet;
		}
	}
	
	void state_in_closet(){
		text.text = "Inside the janitor's closet you see a uniform hanging up in the locker room with a ID card attached to it. "+
					"It's a little big, but it looks like it should fit you fine. \n\n"+
					"Press R to Return to the corridor or D to Dress up in the janitor's uniform";
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.corridor_2;
		}else if(Input.GetKeyDown(KeyCode.D)){
			myState = States.corridor_3;
		}
	}
	////////////////
	
	//corridor set 3
	void state_stairs_2(){
		text.text = "You walk up to the top of the stairs. You try the door, but it's locked. "+
			"You see what looks to be a keycard reader next to it. \n\n"+
				"Press R to Return to the corridor";
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.corridor_2;
		}
	}
	
	void state_corridor_2(){
		text.text = "You again stand in a dimly lit corridor. You see at one of the hall there are stairs leading to an exit door "+
					"and at the other end there is a janitor's closet. \n\n"+
					"Press S to walk to the Stairs or B to go Back into the closet";
		if(Input.GetKeyDown(KeyCode.S)){
			myState = States.stairs_2;
		}else if(Input.GetKeyDown(KeyCode.B)){
			myState = States.in_closet;
		}
	}
	
	void state_corridor_3(){
		text.text = "You enter the corridor again, now fully dressed in a janitor's uniform. "+
			"and at the other end there is a janitor's closet. \n\n"+
				"Press S to walk to the Stairs or U to Undress in the janitor's closet since you feel silly wearing it and it's kind of smelly";
		if(Input.GetKeyDown(KeyCode.S)){
			myState = States.courtyard;
		}else if(Input.GetKeyDown(KeyCode.U)){
			myState = States.in_closet;
		}
	}
	////////////////
	
	//final escape
	void state_courtyard(){
		text.text = "You swipe the janitor's keycard at the top of the door. After a second the door beeps and opens up."+
			"You feel fresh air rush against you as you step outside. Freedom at last! \n\n"+
			"CONGRATULATIONS! YOU ESCAPED FROM PRIIISSSOOONNN!";
	}
	
}

using UnityEngine;
using System.Collections;

public class script_falling_balloon : MonoBehaviour {
	script_player_move player_script;
	
	void Start(){
		player_script = GameObject.FindWithTag("Player").GetComponent<script_player_move>();	
	}
	
	void OnTriggerEnter(Collider other){

		if(other.transform.CompareTag ("tile") && player_script.has_balloon==-1){
				player_script.changeRising(0);
				player_script.hitTop(-1);
		}
	}
	
	void OnTriggerExit(Collider other){
		if (other.transform.CompareTag ("tile") && player_script.has_balloon==-1){
			if (player_script.has_balloon==-1 && player_script.grounded==false){
				player_script.hitTop(0);	
			}	
		}
	}
}

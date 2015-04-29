using UnityEngine;
using System.Collections;

public class caughtPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		// If the thing the enemy hit is the player, 
		// start the level over again
		if(other.gameObject.tag == "player"){
			Application.LoadLevel("flicker");
		}
	}
}

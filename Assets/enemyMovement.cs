using UnityEngine;
using System.Collections.Generic;

public class enemyMovement : MonoBehaviour {
	// Player GameObject
	public GameObject player;
	// First endpoint of patrol path
	public GameObject endPoint1;
	// Second endpoint of patrol path
	public GameObject endPoint2;

	// Hits for straight from transform.forward
	RaycastHit hitFwd;
	RaycastHit hitFwd1;
	RaycastHit hitFwd2;
	RaycastHit hitFwd3;
	RaycastHit hitFwd4;
	RaycastHit hitFwd5;
	RaycastHit hitFwd6;
	RaycastHit hitFwd7;
	RaycastHit hitFwd8;

	// Hits to the left of transform.forward
	RaycastHit hitLeft;
	RaycastHit hitLeft1;
	RaycastHit hitLeft2;
	RaycastHit hitLeft3;
	RaycastHit hitLeft4;
	RaycastHit hitLeft5;
	RaycastHit hitLeft6;
	RaycastHit hitLeft7;
	RaycastHit hitLeft8;

	// Hits to the right of transform.forward
	RaycastHit hitRight;
	RaycastHit hitRight1;
	RaycastHit hitRight2;
	RaycastHit hitRight3;
	RaycastHit hitRight4;
	RaycastHit hitRight5;
	RaycastHit hitRight6;
	RaycastHit hitRight7;
	RaycastHit hitRight8;

	// Hits above
	RaycastHit hitUp;
	RaycastHit hitUp1;
	RaycastHit hitUp2;
	RaycastHit hitUp3;
	RaycastHit hitUp4;

	// List of hits
	List<RaycastHit> hitList = new List<RaycastHit>();

	NavMeshAgent agent;
	// Whether agent should travel to second endpoint
	bool travelToTwo = false;
	// Amount of time since any raycast hit the player
	float timeSinceSeen = 5;
	// Use this for initialization
	void Start () {
		// Get NavMeshAgent and assign
		agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
		// Clear list of hits so it doesn't grow endlessly
		hitList.Clear ();

		// If the enemy is close to the first endpoint,
		// travel to the second endpoint
		if(Vector3.Distance(gameObject.transform.position, endPoint1.transform.position) < 3){
			//Debug.Log ("changing to target 2");
			travelToTwo = true;
		}
		// If the enemy is close to the second endpoint,
		// travel to the first endpoint
		else if(Vector3.Distance(gameObject.transform.position, endPoint2.transform.position) < 3){
			//Debug.Log ("changing to target 1");
			travelToTwo = false;
		}

		// Raycast straight from transform.forward
		Physics.Raycast (gameObject.transform.position, gameObject.transform.forward, out hitFwd, 500);
		// Add all RaycastHits to the list of hits
		hitList.Add (hitFwd);
		// Subsequent raycasts add to the height of transform.forward
		Physics.Raycast (new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y + 1, 
		                          gameObject.transform.position.z), gameObject.transform.forward, out 
		                 hitFwd1, 500);
		hitList.Add (hitFwd1);
		Physics.Raycast (new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y + 2,
		                        gameObject.transform.position.z), gameObject.transform.forward, out
		                hitFwd2, 500);
		hitList.Add (hitFwd2);
		Physics.Raycast (new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y + 3,
		                        gameObject.transform.position.z), gameObject.transform.forward, out
		                hitFwd3, 500);
		hitList.Add (hitFwd3);
		Physics.Raycast (new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y + 4,
		                        gameObject.transform.position.z), gameObject.transform.forward, out
		                hitFwd4, 500);
		hitList.Add (hitFwd4);
		Physics.Raycast (new Vector3 (gameObject.transform.position.x, (float)(gameObject.transform.position.y + 0.5), 
		                              gameObject.transform.position.z), gameObject.transform.forward, out 
		                 hitFwd5, 500);
		hitList.Add (hitFwd5);
		Physics.Raycast (new Vector3 (gameObject.transform.position.x, (float)(gameObject.transform.position.y + 1.5), 
		                              gameObject.transform.position.z), gameObject.transform.forward, out 
		                 hitFwd6, 500);
		hitList.Add (hitFwd6);
		Physics.Raycast (new Vector3 (gameObject.transform.position.x, (float)(gameObject.transform.position.y + 2.5), 
		                              gameObject.transform.position.z), gameObject.transform.forward, out 
		                 hitFwd7, 500);
		hitList.Add (hitFwd7);
		Physics.Raycast (new Vector3 (gameObject.transform.position.x, (float)(gameObject.transform.position.y + 3.5), 
		                              gameObject.transform.position.z), gameObject.transform.forward, out 
		                 hitFwd8, 500);
		hitList.Add (hitFwd8);

		// Raycast to the left of transform.forward
		Physics.Raycast (gameObject.transform.position, gameObject.transform.forward, out hitLeft, 500);
		hitList.Add (hitLeft);
		// Subsequent raycasts add to the height of transform.forward
		Physics.Raycast (new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y + 1, 
		                              gameObject.transform.position.z + 1), gameObject.transform.forward, out 
		                 hitLeft1, 500);
		hitList.Add (hitLeft1);
		Physics.Raycast (new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y + 2,
		                            gameObject.transform.position.z + 1), gameObject.transform.forward, out
		                hitLeft2, 500);
		hitList.Add (hitLeft2);
		Physics.Raycast (new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y + 3,
		                            gameObject.transform.position.z + 1), gameObject.transform.forward, out
		                hitLeft3, 500);
		hitList.Add (hitLeft3);
		Physics.Raycast (new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y + 4,
		                            gameObject.transform.position.z + 1), gameObject.transform.forward, out
		                hitLeft4, 500);
		hitList.Add (hitLeft4);
		Physics.Raycast (new Vector3 (gameObject.transform.position.x, (float)(gameObject.transform.position.y + .5), 
		                              gameObject.transform.position.z + 1), gameObject.transform.forward, out 
		                 hitLeft5, 500);
		hitList.Add (hitLeft5);
		Physics.Raycast (new Vector3 (gameObject.transform.position.x, (float)(gameObject.transform.position.y + 1.5), 
		                              gameObject.transform.position.z + 1), gameObject.transform.forward, out 
		                 hitLeft6, 500);
		hitList.Add (hitLeft6);
		Physics.Raycast (new Vector3 (gameObject.transform.position.x, (float)(gameObject.transform.position.y + 2.5), 
		                              gameObject.transform.position.z + 1), gameObject.transform.forward, out 
		                 hitLeft7, 500);
		hitList.Add (hitLeft7);
		Physics.Raycast (new Vector3 (gameObject.transform.position.x, (float)(gameObject.transform.position.y + 3.5), 
		                              gameObject.transform.position.z + 1), gameObject.transform.forward, out 
		                 hitLeft8, 500);
		hitList.Add (hitLeft8);

		// Raycast to the right of transform.forward
		Physics.Raycast (gameObject.transform.position, gameObject.transform.forward, out hitRight, 500);
		hitList.Add (hitRight);
		// Subsequent raycasts add to the height of transform.forward
		Physics.Raycast (new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y + 1, 
		                              gameObject.transform.position.z - 1), gameObject.transform.forward, out 
		                 hitRight1, 500);
		hitList.Add (hitRight1);
		Physics.Raycast (new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y + 2,
		                            gameObject.transform.position.z - 1), gameObject.transform.forward, out
		                hitRight2, 500);
		hitList.Add (hitRight2);
		Physics.Raycast (new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y + 3,
		                            gameObject.transform.position.z - 1), gameObject.transform.forward, out
		                hitRight3, 500);
		hitList.Add (hitRight3);
		Physics.Raycast (new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y + 4,
		                            gameObject.transform.position.z - 1), gameObject.transform.forward, out
		                hitRight4, 500);
		hitList.Add (hitRight4);
		Physics.Raycast (new Vector3 (gameObject.transform.position.x, (float)(gameObject.transform.position.y + .5), 
		                              gameObject.transform.position.z - 1), gameObject.transform.forward, out 
		                 hitRight5, 500);
		hitList.Add (hitRight5);
		Physics.Raycast (new Vector3 (gameObject.transform.position.x, (float)(gameObject.transform.position.y + 1.5), 
		                              gameObject.transform.position.z - 1), gameObject.transform.forward, out 
		                 hitRight6, 500);
		hitList.Add (hitRight6);
		Physics.Raycast (new Vector3 (gameObject.transform.position.x, (float)(gameObject.transform.position.y + 2.5), 
		                              gameObject.transform.position.z - 1), gameObject.transform.forward, out 
		                 hitRight7, 500);
		hitList.Add (hitRight7);
		Physics.Raycast (new Vector3 (gameObject.transform.position.x, (float)(gameObject.transform.position.y + 3.5), 
		                              gameObject.transform.position.z - 1), gameObject.transform.forward, out 
		                 hitRight8, 500);
		hitList.Add (hitRight8);

		// Raycast in direction of transform.up
		if(Physics.Raycast (gameObject.transform.position, gameObject.transform.up, out hitUp, 500)){
			// Only add hit to the list if the ray hits something
			// This avoids harmless but annoying null pointer exceptions
			hitList.Add (hitUp);
		}
		if(Physics.Raycast (new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y,
		                            gameObject.transform.position.z + 1), gameObject.transform.up, out 
		                 			hitUp1, 500)){
			hitList.Add (hitUp1);
		}
		if(Physics.Raycast(new Vector3(gameObject.transform.position.x, gameObject.transform.position.y,
		                            gameObject.transform.position.z - 1), gameObject.transform.up, out
		                			hitUp2, 500)){
			hitList.Add (hitUp2);
		}
		if(Physics.Raycast(new Vector3(gameObject.transform.position.x, gameObject.transform.position.y,
		                            (float)(gameObject.transform.position.z + 0.5)), gameObject.transform.up,
		                			out hitUp3, 500)){
			hitList.Add (hitUp3);
		}
		if(Physics.Raycast(new Vector3(gameObject.transform.position.x, gameObject.transform.position.y,
		                            (float)(gameObject.transform.position.z - 0.5)), gameObject.transform.up,
		                   out hitUp4, 500)){
			hitList.Add (hitUp4);
		}


		/*Debug.DrawRay (gameObject.transform.position, gameObject.transform.forward*500, Color.magenta);
		Debug.DrawRay (new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y + 1, 
		                              gameObject.transform.position.z), gameObject.transform.forward*500, Color.cyan);
		Debug.DrawRay(new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 2,
		                            gameObject.transform.position.z), gameObject.transform.forward*500, Color.red);
		Debug.DrawRay(new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 3,
		                            gameObject.transform.position.z), gameObject.transform.forward*500, Color.green);
		Debug.DrawRay(new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 4,
		                            gameObject.transform.position.z), gameObject.transform.forward*500, Color.yellow);
		Debug.DrawRay (new Vector3 (gameObject.transform.position.x, (float)(gameObject.transform.position.y + .5), 
		                            gameObject.transform.position.z), gameObject.transform.forward*500, Color.white);
		Debug.DrawRay (new Vector3 (gameObject.transform.position.x, (float)(gameObject.transform.position.y + 1.5), 
		                            gameObject.transform.position.z), gameObject.transform.forward*500, Color.blue);
		Debug.DrawRay (new Vector3 (gameObject.transform.position.x, (float)(gameObject.transform.position.y + 2.5), 
		                            gameObject.transform.position.z), gameObject.transform.forward*500, Color.gray);
		Debug.DrawRay (new Vector3 (gameObject.transform.position.x, (float)(gameObject.transform.position.y + 3.5), 
		                            gameObject.transform.position.z), gameObject.transform.forward*500, Color.white);

		Debug.DrawRay (gameObject.transform.position, gameObject.transform.forward*500, Color.magenta);
		Debug.DrawRay (new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y + 1, 
		                            gameObject.transform.position.z + 1), gameObject.transform.forward*500, Color.cyan);
		Debug.DrawRay(new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 2,
		                          gameObject.transform.position.z + 1), gameObject.transform.forward*500, Color.red);
		Debug.DrawRay(new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 3,
		                          gameObject.transform.position.z + 1), gameObject.transform.forward*500, Color.green);
		Debug.DrawRay(new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 4,
		                          gameObject.transform.position.z + 1), gameObject.transform.forward*500, Color.yellow);
		Debug.DrawRay (new Vector3 (gameObject.transform.position.x, (float)(gameObject.transform.position.y + .5), 
		                            gameObject.transform.position.z + 1), gameObject.transform.forward*500, Color.white);
		Debug.DrawRay (new Vector3 (gameObject.transform.position.x, (float)(gameObject.transform.position.y + 1.5), 
		                            gameObject.transform.position.z + 1), gameObject.transform.forward*500, Color.blue);
		Debug.DrawRay (new Vector3 (gameObject.transform.position.x, (float)(gameObject.transform.position.y + 2.5), 
		                            gameObject.transform.position.z + 1), gameObject.transform.forward*500, Color.gray);
		Debug.DrawRay (new Vector3 (gameObject.transform.position.x, (float)(gameObject.transform.position.y + 3.5), 
		                            gameObject.transform.position.z + 1), gameObject.transform.forward*500, Color.white);

		Debug.DrawRay (gameObject.transform.position, gameObject.transform.forward*500, Color.magenta);
		Debug.DrawRay (new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y + 1, 
		                            gameObject.transform.position.z - 1), gameObject.transform.forward*500, Color.cyan);
		Debug.DrawRay(new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 2,
		                          gameObject.transform.position.z - 1), gameObject.transform.forward*500, Color.red);
		Debug.DrawRay(new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 3,
		                          gameObject.transform.position.z - 1), gameObject.transform.forward*500, Color.green);
		Debug.DrawRay(new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 4,
		                          gameObject.transform.position.z - 1), gameObject.transform.forward*500, Color.yellow);
		Debug.DrawRay (new Vector3 (gameObject.transform.position.x, (float)(gameObject.transform.position.y + .5), 
		                            gameObject.transform.position.z - 1), gameObject.transform.forward*500, Color.white);
		Debug.DrawRay (new Vector3 (gameObject.transform.position.x, (float)(gameObject.transform.position.y + 1.5), 
		                            gameObject.transform.position.z - 1), gameObject.transform.forward*500, Color.blue);
		Debug.DrawRay (new Vector3 (gameObject.transform.position.x, (float)(gameObject.transform.position.y + 2.5), 
		                            gameObject.transform.position.z - 1), gameObject.transform.forward*500, Color.gray);
		Debug.DrawRay (new Vector3 (gameObject.transform.position.x, (float)(gameObject.transform.position.y + 3.5), 
		                            gameObject.transform.position.z - 1), gameObject.transform.forward*500, Color.white);

		Debug.DrawRay (gameObject.transform.position, gameObject.transform.up*500, Color.white);
		Debug.DrawRay (new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z + 1),
		              gameObject.transform.up * 500, Color.cyan);
		Debug.DrawRay (new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z - 1),
		              gameObject.transform.up * 500, Color.green);
		Debug.DrawRay(new Vector3(gameObject.transform.position.x, gameObject.transform.position.y,
		              (float)(gameObject.transform.position.z + 0.5)), gameObject.transform.up*500, Color.red);
		Debug.DrawRay(new Vector3(gameObject.transform.position.x, gameObject.transform.position.y,
		              (float)(gameObject.transform.position.z - 0.5)), gameObject.transform.up*500, Color.yellow);
*/
		// Check if each ray has hit the player
		foreach(var hit in hitList){
			if(hit.collider.gameObject.tag == "player"){
				// Set the time since the player was last seen to 0
				timeSinceSeen = 0;
				// Set the agent's destination to the player
				agent.SetDestination(player.transform.position);
				//Debug.Log ("traveling to player, can see");
				break;
			}
		}

		int notSeeCount = 0;
		// Check if all of the rays are not hitting the player
		foreach(var hit in hitList){
			if(hit.collider.gameObject.tag != "player"){
				notSeeCount++;
			}
		}
		// If none of the rays are hitting the player
		if (notSeeCount == hitList.Count) {
			// If it's been less than 5 seconds since the enemy saw
			// the player
			if(timeSinceSeen < 5){
				// Add to the time since the enemy has seen the player
				timeSinceSeen += Time.deltaTime;
				// Continue moving towards the player
				agent.SetDestination(player.transform.position);
				//Debug.Log("traveling to player, can't see");
			}
			// If it's been more than 5 seconds since the enemy saw
			// the player
			else{
				// Go to endpoint 1
				if(!travelToTwo){
					agent.SetDestination(endPoint1.transform.position);
					//Debug.Log("traveling to 1");
				}
				// Go to endpoint 2
				else if(travelToTwo){
					agent.SetDestination(endPoint2.transform.position);
					//Debug.Log ("traveling to 2");
				}
			}
		}
	}
}

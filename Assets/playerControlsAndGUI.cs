using UnityEngine;
using System.Collections;

public class playerControlsAndGUI : MonoBehaviour {
	public int speed = 10;
	public float shrinkSpeed = .1f;
	public Material electric;
	public Material fire;
	public static bool switchSkin = false;
	RaycastHit hit;
	public static bool isPaused = false;
	public GUIText quit;
	public GUIText escape;


	CharacterController cc;

	//public Vector3 size = Mesh.bounds.size;
	// Use this for initialization
	void Start () {
		cc = GetComponent<CharacterController> ();
		quit.enabled = false;
		escape.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

		if(isPaused){
			Time.timeScale = 0;
			quit.enabled = true;
			escape.enabled = true;
			if(Input.GetKeyDown(KeyCode.Q)){
				Application.Quit();
			}
		}
		else{
			Time.timeScale = 1;
			quit.enabled = false;
			escape.enabled = false;
		}

		if (Input.GetKey ("a")) {
			cc.Move(transform.right*Time.deltaTime*-speed);
		}
		if(Input.GetKey ("d")){
			cc.Move(transform.right*Time.deltaTime*speed);
		}
		if (Input.GetKey ("s")) {
			cc.Move(transform.forward*Time.deltaTime*-1*speed);
		}
		if (Input.GetKey ("w")) {
			cc.Move(transform.forward * Time.deltaTime*speed);
		}
		if(Input.GetKeyDown ("space")){
			switchSkin = !switchSkin;
		}
		if (Input.GetMouseButton (0)) {
			if(Physics.Raycast (gameObject.transform.position, 
			                    gameObject.transform.up, out hit, 1000)){
				cc.Move (Vector3.up*Time.deltaTime*speed);
			}
			else{
				if(gameObject.transform.position.y < 7){
					cc.Move(Vector3.up*Time.deltaTime*speed);
				}
			}
		}
		if(Input.GetKeyDown(KeyCode.Escape)){
			isPaused = !isPaused;
		}
		if (Input.GetMouseButton (1)) {
			cc.Move (Vector3.down*Time.deltaTime*speed);
		}
		if(!switchSkin){
			renderer.material = fire;
		}
		if(switchSkin){
			renderer.material = electric;
		}

		//renderer.bounds.size -= new Vector3(shrinkSpeed * Time.deltaTime,shrinkSpeed * Time.deltaTime,shrinkSpeed * Time.deltaTime);
		//transform.localScale -= new Vector3(shrinkSpeed*Time.deltaTime,shrinkSpeed*Time.deltaTime,shrinkSpeed*Time.deltaTime);
		

	}
}
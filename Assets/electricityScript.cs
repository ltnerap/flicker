using UnityEngine;
using System.Collections;

public class electricityScript : MonoBehaviour {
	public Light pointLight;
	public bool isLit = false;
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void spawnLight(){
		GameObject.Instantiate (pointLight, transform.position, transform.localRotation);
		pointLight.light.color = Color.white;
		pointLight.light.type = LightType.Point;
		pointLight.transform.position = transform.position;
		pointLight.light.intensity = 4;
	}
	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "player") {
			if(playerControlsAndGUI.switchSkin && !isLit){
				spawnLight ();
				isLit = true;
			}
		}
	}
}
	
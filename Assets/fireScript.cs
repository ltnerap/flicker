using UnityEngine;
using System.Collections;

public class fireScript : MonoBehaviour {
	public Light pointLight;
	public Color orange = new Color(247, 115, 32);
	public bool isLit = false;
	void spawnLight(){
		GameObject.Instantiate (pointLight, transform.position, transform.localRotation);
		pointLight.light.color = orange;
		pointLight.light.type = LightType.Point;
		pointLight.transform.position = transform.position;
		pointLight.light.intensity = 2;
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "player") {
			if(!playerControlsAndGUI.switchSkin && !isLit){
				spawnLight ();
				isLit = true;
			}
		}
	}
}

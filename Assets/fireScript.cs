using UnityEngine;
using System.Collections;

public class fireScript : MonoBehaviour {
	public Light pointLight;
	public Color orange = new Color(247, 115, 32);
	public bool isLit = false;
	private AudioSource source;
	ParticleSystem sparks;
	ParticleSystem fire;
	void spawnLight(){
		GameObject.Instantiate (pointLight, transform.position, transform.localRotation);
		pointLight.light.color = orange;
		pointLight.light.type = LightType.Point;
		pointLight.transform.position = transform.position;
		pointLight.light.intensity = 2;
	}
	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource> ();
		sparks = GetComponent<ParticleSystem> ();
		sparks.enableEmission = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "player") {
			if(!playerControlsAndGUI.switchSkin && !isLit){
				spawnLight ();
				isLit = true;
				source.mute = false;
				source.PlayOneShot(source.clip, 1f);
				sparks.enableEmission = true;
			}
		}
	}
}

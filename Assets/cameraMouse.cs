using UnityEngine;
using System.Collections;

public class cameraMouse : MonoBehaviour {

	CharacterController cc;
	// Use this for initialization
	void Start () {
		cc = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0f, Input.GetAxis("Mouse X")*2f, 0f);
	}
}

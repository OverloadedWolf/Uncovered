using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate(new Vector3(-2f*Time.deltaTime,0,0));	
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.Translate(new Vector3(2f*Time.deltaTime,0,0));	
		}
	}
}

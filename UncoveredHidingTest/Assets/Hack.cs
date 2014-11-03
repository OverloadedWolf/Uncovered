using UnityEngine;
using System.Collections;

public class Hide : MonoBehaviour {
	public bool canHack = false;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (canHide) {
			if(Input.GetKeyUp(KeyCode.R)){
				Hacking ();
			}
		}
	}
	
	void OnTriggerEnter2D(Collider2D col){
		if (col.tag == "Hideable") {
			canHack = true;
		}
	}
	void OnTriggerExit2D(Collider2D col){
		if (col.tag == "Hideable") {
			canHack = false;
		}
	}
	void Hacking(){
		gameObject.GetComponent<SpriteRenderer>().sprite = darkP;
		gameObject.transform.Translate(new Vector3(0,.7f,0));
		canHide = false;
	}
	void UnHide(){
		gameObject.GetComponent<SpriteRenderer>().sprite = lightP;
		gameObject.transform.Translate(new Vector3(0,-0.7f,0));
		isHiding = false;
	}
}

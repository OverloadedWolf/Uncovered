using UnityEngine;
using System.Collections;

public class Hide : MonoBehaviour {
	public bool isHiding = false;
	public bool canHide = false;
	public GUITexture eKey;
	public Sprite lightP;
	public Sprite darkP;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (canHide) {
			if(Input.GetKeyUp(KeyCode.E)){
				Hiding ();
			}
		}
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.tag == "Hideable") {
			eKey.enabled = true;
			canHide=true;
		}
	}
	void OnTriggerExit2D(Collider2D col){
		if (col.tag == "Hideable") {
			canHide = false;
			eKey.enabled = false;
			if(isHiding)
				UnHide();
		}
	}
	void Hiding(){
		gameObject.GetComponent<SpriteRenderer>().sprite = darkP;
		gameObject.transform.Translate(new Vector3(0,.7f,0));
		canHide = false;
		isHiding = true;
		eKey.enabled = false;

	}
	void UnHide(){
		gameObject.GetComponent<SpriteRenderer>().sprite = lightP;
		gameObject.transform.Translate(new Vector3(0,-0.7f,0));
		isHiding = false;
	}
}

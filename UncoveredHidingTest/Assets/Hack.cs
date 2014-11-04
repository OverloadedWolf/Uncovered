using UnityEngine;
using System.Collections;

public class Hack : MonoBehaviour {
	public bool canHack = false;
	public bool beenHacked = false;
	public float speed = 2;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (canHack) {
			if(Input.GetKeyUp(KeyCode.R)){
				Open ();
			}
		}
	}
	
	void OnTriggerEnter2D(Collider2D col){
		if (col.tag == "Player") {
			canHack = true;
		}
	}
	void OnTriggerExit2D(Collider2D col){
		if (col.tag == "Player") {
			canHack = false;
			//Close();
		}
	}
	void Open(){
		transform.Translate(new Vector3(0,10f,0));
	}
	//void Close(){
		//transform.Translate(new Vector3(0,-4f,0));
	//}
}

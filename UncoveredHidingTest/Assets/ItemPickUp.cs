using UnityEngine;
using System.Collections;

public class ItemPickUp : MonoBehaviour {
	public bool canPickUp = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(canPickUp){
			if(Input.GetKeyUp(KeyCode.F))
			   Destroy(gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.tag == "Player"){
			canPickUp = true;
		}
	}

	void OnTriggerExit2D(Collider2D col){
		if(col.tag == "Player"){
			canPickUp = false;
		}
	}
}

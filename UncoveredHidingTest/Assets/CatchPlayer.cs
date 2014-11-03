using UnityEngine;
using System.Collections;

public class CatchPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D col){
		if (col.tag == "Player") {
			if(!col.gameObject.GetComponent<Hide>().isHiding){
				GameObject.Find("Status Text").guiText.text = "You have been caught!";
				Destroy(col.gameObject);
			}
		}
	}
}

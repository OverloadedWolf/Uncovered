using UnityEngine;
using System.Collections;

public class ScientistPath : MonoBehaviour {
	public GameObject[] nodes;
	public int curNode = 0;
	float xS;
	//float yS;
	// Use this for initialization
	void Start () {
		xS = transform.position.x;
		//yS = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		xS = transform.position.x;
		//yS = transform.position.y;
		transform.position = Vector3.MoveTowards (transform.position, nodes [curNode].transform.position, Time.deltaTime);
		if (xS < transform.position.x) {
			transform.localScale = new Vector3 (-1f, 1f, 1f);
		} else {
			transform.localScale = new Vector3 (1f ,1f ,1f);	
		}
		if (Vector3.Distance (transform.position, nodes [curNode].transform.position) < .1f) {
			curNode ++;
			if(curNode>=nodes.Length){
				curNode = 0;
			}
		}
		for(int i = 0; i < nodes.Length-1; i ++){
			Debug.DrawRay(nodes[i].transform.position,nodes[i+1].transform.position-nodes[i].transform.position,Color.red);
		}
	}
}

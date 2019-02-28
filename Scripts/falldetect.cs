using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falldetect : MonoBehaviour {
Vector3 checkpoint;
	// Use this for initialization
	void Start () {
		checkpoint = new Vector3 (170,-104,247);
		
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.y < -120) {
			transform.position = checkpoint;
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveBike : MonoBehaviour {
	Vector3 checkpoint;
	public GameObject Bike;
	public GameObject Szene;
[SerializeField] private Canvas customCanvas;
	
	void Start () {
	
	checkpoint = new Vector3 (73,-75,-24);
	
}


	void OnTriggerStay(Collider other) {
			
		if (Input.GetButton("Fire2"))
        {
			Bike.transform.position = checkpoint;
			Szene.SetActive(true);
			customCanvas.enabled = false;
           
        }	
    }
}

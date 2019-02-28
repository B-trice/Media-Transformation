using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showText : MonoBehaviour {

	[SerializeField] private GameObject Canvas;
	
	void OnTriggerEnter(Collider other) {
		if(other.CompareTag("Player")) {
			
			Canvas.SetActive(true);
			
    }
			
		}
	
	void OnTriggerExit(Collider other) {
		if(other.CompareTag("Player")) {
			
			Canvas.SetActive(true);
		}
	}	
	}
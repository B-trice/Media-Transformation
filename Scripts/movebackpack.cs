using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movebackpack : MonoBehaviour {
	Vector3 checkpoint;
	[SerializeField] private Light Fahrrad;
	public GameObject Funktion;
	[SerializeField] private Canvas customCanvas;
	[SerializeField] private Light Text1;
	[SerializeField] private Light Text2;
	[SerializeField] private Canvas Text;
	
void Start () {
	
	checkpoint = new Vector3 (69,-57,-36);
	
}

void OnTriggerStay(Collider other) {
			
		if (Input.GetButton("Fire2"))
        {
            transform.position = checkpoint;
			Fahrrad.enabled = true;
			Funktion.SetActive(true);
			customCanvas.enabled = false;
			Text2.enabled = true;
			Text1.enabled = false;
			Text.enabled = true;
			
        }	
    }
	
}

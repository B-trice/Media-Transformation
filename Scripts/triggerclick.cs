using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class triggerclick : MonoBehaviour {

 public string LevelName;
	
	void OnTriggerStay(Collider other) {
			
		if (Input.GetButton("Fire2"))
        {
            SceneManager.LoadScene(LevelName);
        }
			
    }
	
}

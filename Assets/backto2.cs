using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class backto2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Button>().onClick.AddListener(myAction);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void myAction(){
        Camera.main.GetComponent<draw>().enabled = false;

        Camera.main.GetComponent<main_controller>().show_map();
    }
}

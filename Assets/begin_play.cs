using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class begin_play : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Button>().onClick.AddListener(myAction);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void myAction(){
        Camera.main.GetComponent<main_controller>().show_map();
    }
}

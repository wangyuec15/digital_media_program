using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class forplaybutton : MonoBehaviour {
    GameObject content;
	// Use this for initialization
	void Start () {
        content = gameObject.transform.parent.parent.gameObject;
        gameObject.GetComponent<Button>().onClick.AddListener(playvideo);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void playvideo(){
        content.GetComponent<show_which_year>().playvideo();
    }
}

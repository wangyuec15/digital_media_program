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

        Transform panel3 = Camera.main.GetComponent<main_controller>().panel3.transform;
        foreach (Transform child in panel3.Find("south"))
        {
            child.gameObject.GetComponent<dragpeople>().drawme = false;
            child.gameObject.GetComponent<Image>().color = new Color(1, 1, 1, 1);
        }
        foreach (Transform child in panel3.Find("middle"))
        {
            child.gameObject.GetComponent<dragpeople>().drawme = false;
            child.gameObject.GetComponent<Image>().color = new Color(1, 1, 1, 1);
        }
        foreach (Transform child in panel3.Find("north"))
        {
            child.gameObject.GetComponent<dragpeople>().drawme = false;
            child.gameObject.GetComponent<Image>().color = new Color(1, 1, 1, 1);
        }
        Camera.main.GetComponent<draw>().enabled = false;

        Camera.main.GetComponent<main_controller>().show_map();
    }
}

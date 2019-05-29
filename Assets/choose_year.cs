using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class choose_year : MonoBehaviour {
    GameObject dropdownlist;
    GameObject thislist;
	// Use this for initialization
	void Start () {
        dropdownlist = Resources.Load("dropdownlist")as GameObject;
        gameObject.GetComponent<Button>().onClick.AddListener(yearlist);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void yearlist(){
        if (thislist == null)
        {
            thislist = Instantiate(dropdownlist, gameObject.transform.parent.parent);
        }else{
            Destroy(thislist);
        }
    }
}

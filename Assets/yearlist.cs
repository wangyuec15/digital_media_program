using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class yearlist : MonoBehaviour {
    public Text now_year;
    public GameObject thisblock;


	// Use this for initialization
	void Start () {
        now_year = gameObject.transform.parent.Find("yeararea").Find("year").GetComponent<Text>();
        thisblock = gameObject.transform.parent.gameObject;
        gameObject.transform.GetChild(0).GetComponent<Button>().onClick.AddListener(in2018);
        gameObject.transform.GetChild(1).GetComponent<Button>().onClick.AddListener(in2014);
        gameObject.transform.GetChild(2).GetComponent<Button>().onClick.AddListener(in2010);
        gameObject.transform.GetChild(3).GetComponent<Button>().onClick.AddListener(in2009);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void in2018(){
        now_year.text = "2018";
        thisblock.GetComponent<show_which_year>().set_inside();
        Destroy(gameObject);
    }
    void in2014()
    {
        now_year.text = "2014";
        thisblock.GetComponent<show_which_year>().set_inside();
        Destroy(gameObject);
    }
    void in2010()
    {
        now_year.text = "2010";
        thisblock.GetComponent<show_which_year>().set_inside();
        Destroy(gameObject);
    }
    void in2009()
    {
        now_year.text = "2009";
        thisblock.GetComponent<show_which_year>().set_inside();
        Destroy(gameObject);
    }
}

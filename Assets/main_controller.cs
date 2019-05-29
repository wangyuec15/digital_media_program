using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class main_controller : MonoBehaviour {
    public GameObject panel1,panel2,panel3,panel4;
    public GameObject peoples;
    GameObject districtIntroduce;
    public Image peopleshowing;
    public Text intruduce;
    public Text name;

	// Use this for initialization
	void Start () {
        panel1 = GameObject.Find("Panel1");
        panel2 = GameObject.Find("Panel2");
        panel3 = GameObject.Find("Panel3");
        panel4 = GameObject.Find("Panel4");
        peoples = Resources.Load("peoples")as GameObject;
        districtIntroduce = panel3.transform.Find("introduce").Find("content").gameObject;
        start_page();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void start_page(){
        panel1.SetActive(true);
        panel2.SetActive(false);
        panel3.SetActive(false);
        panel4.SetActive(false);
    }
    public void show_map(){
        panel1.SetActive(false);
        panel2.SetActive(true);

        panel3.SetActive(false);
        panel4.SetActive(false);
    }
    public void show_district(){
        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(true);
        districtIntroduce.SetActive(true);

        panel4.SetActive(false);

        //Camera.main.GetComponent<draw>().enabled = true;
    }
    public void people_detail(){
        panel1.SetActive(false);
        panel2.SetActive(false);

        //panel3.SetActive(false);
        districtIntroduce.SetActive(false);
        panel4.SetActive(true);
    }
}

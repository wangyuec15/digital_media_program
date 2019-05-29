using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class dragpeople : MonoBehaviour {


    Vector3 offset;
    Vector3 clickpoint;
    private Vector3 targetScreenPoint;
    Image showing;
    Text name;
    Text introduce;
    public bool drawme;


	// Use this for initialization
	void Start () {
        targetScreenPoint = Camera.main.WorldToScreenPoint(transform.position);
        showing = Camera.main.GetComponent<main_controller>().peopleshowing;
        introduce = Camera.main.GetComponent<main_controller>().intruduce;
        name = Camera.main.GetComponent<main_controller>().name;

	}
	
	// Update is called once per frame
	void Update () {
        
	}
    private void OnMouseDown()
    {
            offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, targetScreenPoint.z));
        clickpoint = Input.mousePosition;
    }

    void OnMouseDrag()
    {
        print("23333333");


        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, targetScreenPoint.z);
        Vector3 curWorldPoint = Camera.main.ScreenToWorldPoint(curScreenPoint);
        gameObject.GetComponent<Transform>().position=(curWorldPoint + offset);


    
    }
    private void OnMouseUp()
    {
        if(Input.mousePosition==clickpoint)
        {
            foreach (Transform child in transform.parent){
                child.gameObject.GetComponent<dragpeople>().drawme = false;
                child.gameObject.GetComponent<Image>().color = new Color(1, 1, 1, 0.5f);
            }
            gameObject.GetComponent<Image>().color = new Color(1, 1, 1, 1);
            foreach(Transform link in gameObject.GetComponent<force>().linked){
                link.gameObject.GetComponent<Image>().color = new Color(1, 1, 1, 1);
            }

            drawme = true;
            foreach(Transform link in gameObject.GetComponent<force>().linked){
                link.gameObject.GetComponent<dragpeople>().drawme = true;
            }
            Camera.main.GetComponent<main_controller>().people_detail();

            showing.sprite = gameObject.GetComponent<Image>().sprite;

            name.text = gameObject.name;

            Dictionary<string, string> myd = Camera.main.GetComponent<readJson>().people[gameObject.name] as Dictionary<string, string>;

            string myt = "    ";
            foreach(string key in myd.Keys){
                myt += key;
                myt += " : ";
                myt += myd[key];
                myt += "\n\n    ";
            }
            introduce.text = myt;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particle : MonoBehaviour {
    GameObject single;
    public GameObject lefttop, rightbottom;
    int num = 20;
	// Use this for initialization
	void Start () {
        single = Resources.Load("people_icon") as GameObject;
        createpeople();
        lefttop = GameObject.Find("lt");
        rightbottom = GameObject.Find("rb");
    }
	
	// Update is called once per frame
	void Update () {
        //particlemove();
	}

    //void particlemove()
    //{
    //    for (int i = 0; i < gameObject.transform.childCount; i++)
    //    {
    //        gameObject.transform.GetChild(i).GetComponent<force>().acceleration = Vector3.zero;

    //        for (int j = 0; j < gameObject.transform.childCount; j++)
    //        {
    //            if (i != j)
    //            {
    //                Transform pi = gameObject.transform.GetChild(i);
    //                Transform pj = gameObject.transform.GetChild(j);

    //                Vector3 ipos = gameObject.transform.GetChild(i).position;
    //                Vector3 jpos = gameObject.transform.GetChild(j).position;
    //                float distance = Vector3.Distance(ipos,jpos);
    //                if (distance < 1) distance = 1;

    //                float force = distance -3.2f * pj.GetComponent<force>().mass / distance;
    //                pi.GetComponent<force>().acceleration += force * (jpos - ipos);
    //            }
    //        }
    //        gameObject.transform.GetChild(i).GetComponent<force>().velocity = gameObject.transform.GetChild(i).GetComponent<force>().velocity * 0.79f + gameObject.transform.GetChild(i).GetComponent<force>().acceleration*0.03f;
    //    }
    //}
    void createpeople(){
        for (int i = 0; i < num;i++ ){
            GameObject thispeople = Instantiate(single,(lefttop.transform.position + rightbottom.transform.position) / 2,Quaternion.identity, gameObject.transform);
            //thispeople.transform.localScale *= Random.Range(0.7f, 1.5f);
            //thispeople.GetComponent<Transform>().position = (thispeople.GetComponent<force>().lefttop.position + thispeople.GetComponent<force>().rightbottom.position) / 2;
            //thispeople.GetComponent<force>().lefttop = lefttop.transform;
            //thispeople.GetComponent<force>().rightbottom = rightbottom.transform;
            Debug.Log((lefttop.transform.position + rightbottom.transform.position) / 2);
        }
        Camera.main.GetComponent<draw>().enabled = true;
    }
}

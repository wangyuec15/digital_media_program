using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class openarea : MonoBehaviour
{
    GameObject panel3;
    public GameObject northpeople, middlepeople, southpeople;
    Text title;
    Text info;
    // Use this for initialization
    void Start()
    {
        panel3 = GameObject.Find("Panel3");
        title = panel3.transform.Find("introduce").Find("content").Find("title").GetComponent<Text>();
        info = panel3.transform.Find("introduce").Find("content").Find("text").GetComponent<Text>();
        gameObject.transform.Find("north").GetComponent<Button>().onClick.AddListener(north);
        gameObject.transform.Find("middle").GetComponent<Button>().onClick.AddListener(middle);
        gameObject.transform.Find("south").GetComponent<Button>().onClick.AddListener(south);

    }

    // Update is called once per frame
    void Update()
    {

    }
    void north()
    {
        Camera.main.GetComponent<main_controller>().show_district();
        title.text = "台湾北部地区";
        info.text = "城市：台北市 新北市 基隆市 桃园市 新竹市\n\n县城：宜兰县 新竹县 苗栗县";

        middlepeople.SetActive(false);
        southpeople.SetActive(false);
        northpeople.SetActive(true);
        Camera.main.GetComponent<draw>().enabled = true;
        Camera.main.GetComponent<draw>().panel = northpeople;
    }
    void middle()
    {
        Camera.main.GetComponent<main_controller>().show_district();
        title.text = "台湾中部地区";
        info.text = "城市：台中市\n\n县城：彰化县 南投县 花莲县 澎湖县";

        southpeople.SetActive(false);
        northpeople.SetActive(false);
        middlepeople.SetActive(true);
        Camera.main.GetComponent<draw>().enabled = true;
        Camera.main.GetComponent<draw>().panel = middlepeople;

    }
    void south()
    {
        Camera.main.GetComponent<main_controller>().show_district();
        title.text = "台湾南部地区";
        info.text = "城市：台南市 高雄市 屏东市 嘉义市 台东市\n\n县城：嘉义县 云林县 台东县";

        northpeople.SetActive(false);
        middlepeople.SetActive(false);
        southpeople.SetActive(true);
        Camera.main.GetComponent<draw>().enabled = true;
        Camera.main.GetComponent<draw>().panel = southpeople;

    }
}

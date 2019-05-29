using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class show_which_year : MonoBehaviour
{

    public Text thistear;
    public Text content;
    public VideoPlayer video;
    public readJson json;
    public Texture background;
    // Use this for initialization
    void Start()
    {
        thistear = gameObject.transform.Find("yeararea").Find("year").GetComponent<Text>();
        content = gameObject.transform.Find("introducearea").Find("text").GetComponent<Text>();
        video = gameObject.transform.Find("moviearea").Find("video").GetComponent<VideoPlayer>();
        json = Camera.main.GetComponent<readJson>();
        set_inside();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void set_inside()
    {
        video.gameObject.SetActive(false);


        if (thistear.text == "2018")
        {
            content.text = json.xuanjugaikuang[0].ToString();
            video.clip = json.linianshipin[0] as VideoClip;
            gameObject.transform.parent.parent.parent.Find("background").GetComponent<RawImage>().texture = json.selectresult[0] as Texture;
        }
        else if (thistear.text == "2014")
        {
            content.text = json.xuanjugaikuang[1].ToString();
            video.clip = json.linianshipin[1] as VideoClip;
            gameObject.transform.parent.parent.parent.Find("background").GetComponent<RawImage>().texture = json.selectresult[1] as Texture;
        }
        else if (thistear.text == "2010")
        {
            content.text = json.xuanjugaikuang[2].ToString();
            video.clip = json.linianshipin[2] as VideoClip;
            gameObject.transform.parent.parent.parent.Find("background").GetComponent<RawImage>().texture = json.selectresult[2] as Texture;
        }
        else if (thistear.text == "2009")
        {
            content.text = json.xuanjugaikuang[3].ToString();
            video.clip = json.linianshipin[3] as VideoClip;
            gameObject.transform.parent.parent.parent.Find("background").GetComponent<RawImage>().texture = json.selectresult[3] as Texture;
        }
    }
    public void playvideo()
    {
        video.gameObject.SetActive(true);
    }
}

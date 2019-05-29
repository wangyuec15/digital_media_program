using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zhanglishan : MonoBehaviour {
    public Dictionary<string, string> info;
	// Use this for initialization
	void Start () {
        set_renwu();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void set_renwu()
    {

        info = new Dictionary<string, string>();
        info.Add("地区", "云林县");
        info.Add("党派", "国民党");
        info.Add("选举主张", "整体愿景：为年轻人找头路，为老年人找依靠，为企业找机会，为弱势找尊严，为云林找出路带动经济发展：改制云林国际商港，翻转产业结构。");
        info.Add("两岸观点", "秉持 “ 九二共识 ” 处理两岸交流，并将成立 “ 两岸工作小组 ”，推动两岸交流合作。");
        info.Add("政治经历", "立法院（第六届）委员\n立法院最高顾问\n中国国民党云林县长候选人\n中国国民党云林县长候选人\n行政院云嘉南区联合服务中心第4任执行长\n立法院（第九届）委员\n云林县政府（第18届）县长\n ");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class readJson : MonoBehaviour {
    public ArrayList xuanjugaikuang;
    public ArrayList linianshipin;
    public ArrayList selectresult;


    public Dictionary<string, Dictionary<string, string>> people;
	// Use this for initialization
	void Awake () {
        set_xuanjugaikuang();
        set_renwu();
	}
	
	// Update is called once per frame
	void Update () {
		



	}
    void set_xuanjugaikuang(){
        xuanjugaikuang = new ArrayList();
        xuanjugaikuang.Add("本届选举是蔡英文政府自2016年5月20日上任后的首场全国性选举，也是2020年总统大选前哨战。然而选举结果显示，中国国民党大胜；民主进步党遭遇严重挫败的局势，比前总统马英九在第二任总统执政期间的败选状况更为严重，部分长期由民进党执政的县市甚至遭遇翻转，可视为人民对蔡政府的政策投下了不信任票。\n此次选举应选名额共计1万1047名，完成参选登记人数分别为：25位直辖市长、751位直辖市议员、68位省辖县（市）长、1018位省辖县（市）议员、529位乡（镇、市）长、3443位乡（镇、市）民代表、1万5040位村（里）长、21位直辖市山地原住民区长、98位直辖市山地原住民区民代表候选人。\n当选人于2018年12月25日就职。");
        xuanjugaikuang.Add("本届选举是中华民国总统马英九在2012年连任总统后的首场全国性选举，为中华民国政治日后发展的关键指标。该届选举亦是台湾政治史上最大规模的地方选举，应选出的公职人员总数达11,130人。本届选举与往常不同之处，是经由部分项目选举延后一年，而将所有地方公职人员选举合并举行，以减少选务经费，降低社会成本。从本届开始，只有“地方”（即本选举）和“中央”（总统及立法院）两个层级的选举，每隔两年轮替举行。\n本届选举是自1994年中华民国省市长选举以来最大规模的地方层级选举。本次选举亦是参选人数最多的一次，登记参选人数共19,762人。");
        xuanjugaikuang.Add("此次选举为台北市改制直辖市并实施市长直选以来之第5届市长选举，及改制直辖市后的第11届市议员及里长选举，同时亦为改制后新成立之新北市、台中市、台南市及高雄市之第1届市长、市议员及里长选举。\n另外，这场选举亦是续2009年地方公职人员选举后中国国民党的马英九政府所面临的另一次全国性选举，被视为对新政府的另一轮信任投票。由于五个直辖市的人口合计达一千三百七十万，占全台湾总人口的百分之六十左右，故此次选举被视为台湾政治局势日后发展的关键指标，同时也具有2012年中华民国总统选举前哨战的重大意义。国民党有无能力维持其在台北市及台中地区近十年的执政，并巩固2005年甫拿下且蓝绿差距较小的新北市（台北县）、民进党是否得以维持其在台南及高雄地区长年来的执政，都是这次选举的焦点。");
        xuanjugaikuang.Add("此次选举为台湾省实施地方自治以来之第16届县市长及乡镇市长选举及第17届县市议员选举（新竹市及嘉义市因较晚改制，故为第8届）；同时亦为福建省之金门县及连江县实施地方自治以来之第5届县市长、县市议员及乡镇长选举。\n同时，这场选举亦是2008年民主进步党卸下执政权、中国国民党的马英九政府执政后面对的首次全国性选举，被视为对马英九政府的信任投票，不过得票率有蓝消绿长的趋势。其结果如下：\n县市长选举:国民党仍保有多数席次，共获17席中的12席，连同脱党参选后当选者，泛蓝共获13席。民进党虽获得4席，但成功夺回被视为本次选举的指标─宜兰县。");
        linianshipin = new ArrayList();
        linianshipin.Add(Resources.Load("2018")as VideoClip);
        linianshipin.Add(Resources.Load("2014")as VideoClip);
        linianshipin.Add(Resources.Load("2010")as VideoClip);
        linianshipin.Add(Resources.Load("2009")as VideoClip);
        selectresult = new ArrayList();
        selectresult.Add(Resources.Load("2_touse") as Texture);
        selectresult.Add(Resources.Load("2014_touse") as Texture);
        selectresult.Add(Resources.Load("2010_touse") as Texture);
        selectresult.Add(Resources.Load("2009_touse") as Texture);
    }
    void set_renwu(){
        people =new Dictionary<string, Dictionary<string, string>>();

        Dictionary<string,string> kewenzhe = new Dictionary<string, string>();
        kewenzhe.Add("地区", "台北");
        kewenzhe.Add("党派", "无");
        kewenzhe.Add("选举主张", "政治：开放政府、全民参与、公开透明、务实对话\n交通：绿能、共享、安全、E 化，发展「以人为本」的运输环境\n文化：多元文化，生活美学，历史保护，美学教育，扩展文化产业，文化在野\n多元族群：全城平权\n韧性城市：不只要抗灾，更要防灾、减灾，田园城市，海绵城市\n教育：平等教育、智慧教育、实验教育、美感教育、平权教育、国际化教育\n住宅：提供可负担居住的环境，公共住宅，租金分级补贴，住宅安全\n养老：延长健康时间，独居安全，日间照料，社区医院");
        kewenzhe.Add("两岸观点", "一五新观点：尊重两岸过去已经签署的协议和互动的历史，在既有的政治基础上，以互相认识、互相了解、互相尊重、互相合作\n两岸一家亲：早在2015年柯文哲已提过“两岸一家亲”的概念，且柯文哲的“两岸一家亲”定义非指政治状态，其初衷是希望两岸彼此谅解");
        kewenzhe.Add("政治经历","踏入政坛：1994年陈水扁选台北市市长时，柯文哲为扁医界后援会干部。2000年，柯文哲担任陈水扁竞选总统台大医院后援会召集人\n参选台北市市长（2014年）：柯文哲最终在11月29日以853, 983票、57.16 % 的得票率，成为台北市改制为直辖市后的首任无党籍市长\n台北市长任内：柯文哲市长任内除了保留他在政治素人时期的“有话直说、不假修饰”、“庶民气息的亲和力”、“机智幽默的应答对策”、“争议性言论”、“回避”五种说话风格外，更增加了“我行我素”风格，面对敏感政治议题则使用较多“回避”风格，展现“政治素人”到“政治人物”的改变\n参选台北市市长（2018年）：九合一选举于2018年11月25日开票结果出炉，柯文哲险胜成功连任");

        people.Add("柯文哲", kewenzhe);


        Dictionary<string, string> zhanglishan = new Dictionary<string, string>();
        zhanglishan.Add("地区", "云林县");
        zhanglishan.Add("党派", "国民党");
        zhanglishan.Add("选举主张", "整体愿景：为年轻人找头路，为老年人找依靠，为企业找机会，为弱势找尊严，为云林找出路带动经济发展：改制云林国际商港，翻转产业结构。");
        zhanglishan.Add("两岸观点", "秉持 “ 九二共识 ”处理两岸交流，并将成立 “ 两岸工作小组 ”，推动两岸交流合作。");
        zhanglishan.Add("政治经历", "立法院（第六届）委员\n立法院最高顾问\n中国国民党云林县长候选人\n中国国民党云林县长候选人\n行政院云嘉南区联合服务中心第4任执行长\n立法院（第九届）委员\n云林县政府（第18届）县长\n ");

        people.Add("张丽善",zhanglishan);

        Dictionary<string, string> lijinyong = new Dictionary<string, string>();
        lijinyong.Add("地区", "云林县");
        lijinyong.Add("党派", "民进党");
        lijinyong.Add("选举主张", "生活：打造宜居农村、建设在地特色生活圈；建构全县公共运输路网、提供DRTS运输模式。\n就业：推动多元劳工培力，提供多元机会协助劳工接轨职场。\n休闲：打造云林观光六大新亮点：1.云林溪水域景观2.西螺区文旅新创与深化3.虎尾历史场域与央广音像旅栈园区4.台17线宗教文化费:术与观光廊带5.结合北港魅力与水林特色及口湖地景之观光质感打造金水1646.斗南大埤三铁(台铁、糖铁、铁马)共构亮点等。\n经济：打造农业与绿能的绿金双首都，增加就业，持续农水路更新改善。\n健康：建立以农业及高龄者专业医学中心。\n环保：严格落实环保标准、推动工业锅炉改善。\n弱势群体：设立肢体障碍生活重建中心，推动儿童及少年未来教育与发展帐户加倍补助计蛊，\n财政：强化县有财产使用效益，降低公债、减轻县民负担，健全财政结构。\n农业：建构完整农业产销贮送系统。");
        lijinyong.Add("两岸观点", "李进勇「大陆方面这次没有太过恶意的言语，相当务实。」期许两岸能良性发展，「台湾展现多元包容，期待对岸有同样心态。」");
        lijinyong.Add("政治经历", "立法院（第二届）委员\n民主进步党基隆市党部第三届主任委员\n立法院（第三届）委员\n基隆市市长（第十三届）\n民进党中央党部副秘书长\n内政部政务次长\n行政院公共工程委员会副主委\n云林县代理县长\n法务部政务次长\n交通部政务次长\n第17届云林县县长\n正直办公室主委\n ");

        people.Add("李进勇",lijinyong);

        Dictionary<string, string> linjiayu = new Dictionary<string, string>();
        linjiayu.Add("地区", "云林县");
        linjiayu.Add("党派", "无");
        linjiayu.Add("选举主张", "整体主张：以人文與資源為主軸，落實人與環境的共生共榮，力推「微力軍團」將長照升級到4.0。");
        linjiayu.Add("政治经历", "民國83年開業負責人至今牙醫診所院長 ");

        people.Add("林家瑜", linjiayu);

        Dictionary<string, string> wangliping = new Dictionary<string, string>();
        wangliping.Add("地区", "云林县");
        wangliping.Add("党派", "无");
        wangliping.Add("选举主张", "整体主张：青银共居、生态跳岛政策，整合解决云林县人口老化、老屋保存、青年居住、世代共存、文化传承、社区营造的困境。");
        wangliping.Add("政治经历", "1985郑南榕「自由时代周刊」资料室编辑。\n1986当选云林县第11、12、13届县议员。\n1995民进党第一位女性党部主委推动性别参政保障条款。\n2000第四届立法委员。\n2006红衫军副总指挥。\n2016创办盖亚基地。\n ");

        people.Add("王丽萍", wangliping);

        Dictionary<string, string> wuyuren = new Dictionary<string, string>();
        wuyuren.Add("地区", "嘉义县");
        wuyuren.Add("党派", "国民党");
        wuyuren.Add("选举主张", "农业：重新检讨错误的水利与防洪设施，建置防洪计划。建立全国农渔产业营运中心。由县府主导提高农产附加价值。\n经济：发展台湾的产业合作平台，讯提升产业价值。弱势族群促进就业，加强第二职业专长训练，开创青年创业机会。\n旅游：善用嘉义自然观光资源，向世界宣传。建立普及完善大众观光运输系统，吸引国际旅客。\n养老：落实长照2.0政策，减缓人口老化因应高龄社会失能人口的行动需求。\n教育：增设非营利幼儿园，并提高幼儿津贴。\n文化：推动传统工艺品认证与文创商品行销。发展一乡一特色文化节庆，发扬本土文创产业。");
        wuyuren.Add("两岸观点", "吴育仁认为，两岸与国际的内外情势都在不断的变化，此一时也彼一时也，台湾的筹码已经愈来愈少，国民党在两岸政策坚持九二共识，但九二共识的内容论述，除了一中各表之外，也要探讨进阶版的可能性，也应该一起来探讨2.0版，亦即以和平协议解决两岸敌对的可能性，不必完全固守在1.0版。");
        wuyuren.Add("政治经历", "马英九吴敦义云林县与嘉义县竞选办公室副总干事\n郭添财竞选大台南市长总部发言人兼文宣议题小组召集人\n林德瑞竞选嘉义县立委总部发言人\n吴威志竞选云林县长总部发言人暨文宣总召集人\n国立中正大学劳工关系学系教授\n考试院典试委员\n台湾总工会策略委员会委员\n县市劳资争议仲裁委员\n云林县国际工商经营研究社创社社长\n立法院（第八届）委员\n立法院社福及卫环委员会委员\n立法院程序委员会委员\n孙文学校云嘉南分院院长\n中国国民党政策会副执行长\n ");

        people.Add("吴育仁", wuyuren);

        Dictionary<string, string> wenzhangliang = new Dictionary<string, string>();
        wenzhangliang.Add("地区", "嘉义县");
        wenzhangliang.Add("党派", "民进党");
        wenzhangliang.Add("选举主张", "农业–成立「新农业发展委员会」，针对农渔民的生产技术、资金、行销及通路提供协助。\n产业–筹设具有研究、生物科技及冷链系统的「农渔产业园区」，及整合医疗、智慧照护、器材、培训的「长照产业园区」。\n旅游–整合观光轴线，透过异业合作，针对不同消费族群，推出特色游程，共享观光经济。\n养老–组织工作小组跨域整合卫生、社福及教育，协助社区扩展能量，推动不老运动，创造不老社区。\n教育–强化在地学习，深根教育，尊重多元文化价值，培育国际接轨能力。\n乡村–以村里为单位的全县生活大调查，了解各村里需求，改善村里生活环境。");
        wenzhangliang.Add("两岸观点", "民进党嘉义县长当选人翁章梁强调，台湾走向全球，不能只靠单一市场，两岸要朝各方面合作发展，台湾从未拒绝，前提是中国是否解除自我限制，释出善意。");
        wenzhangliang.Add("政治经历", "立法院（第二届）委员\n民主进步党基隆市党部第三届主任委员\n立法院（第三届）委员\n基隆市市长（第十三届）\n民进党中央党部副秘书长\n内政部政务次长\n行政院公共工程委员会副主委\n云林县代理县长\n法务部政务次长\n交通部政务次长\n第17届云林县县长\n正直办公室主委\n ");

        people.Add("翁章梁", wenzhangliang);

        Dictionary<string, string> wufangming = new Dictionary<string, string>();
        wufangming.Add("地区", "嘉义县");
        wufangming.Add("党派", "无");
        wufangming.Add("选举主张", "农业：以智慧科技研究提升农渔牧产品品质\n产业：开发产业园区，利用科技研发辅导产业升级与转型\n就业：创造青年留嘉就业和创业的机会与环境\n医疗：推动智慧健康医疗长照，以资讯科技结合医护居家服务健全体系\n教育：发展多语教育，培养学生多元兴趣和跨域学习\n文化观光：发展艺文和文化创意产业，为观光产业加值\n水利：持续落实治水，进行治水整体配套规划和建设\n托幼：提升婴幼儿照顾和教育福利与环境，促进生育率，并减少青年家长负担\n弱势群体：关怀弱势群体，提升保障权益\n智慧城市：以资讯科技技术应用至各个领域，建设智慧城市嘉园。");
        wufangming.Add("政治经历", "嘉义县副县长\n文观局长\n民政处长\n民进党青年部及主席室副主任\n立委办公室主任\n亚太电信主秘\n文化大学讲师\n南华大学助理教授\n自由时报「政经人视界」\n镜传媒「铭看天下」作者\n复旦大学企管博士候选人\n北京清华大学经济学博士候选人");

        people.Add("吴芳铭", wufangming);

        Dictionary<string, string> linguolong = new Dictionary<string, string>();
        linguolong.Add("地区", "嘉义县");
        linguolong.Add("党派", "无");
        linguolong.Add("选举主张", "反同：反对同性恋结婚。\n就业：四万元起薪，住者有其屋，让年青人成家立业。\n养老：老人全由国家照顾，\n医疗：看病免费，妇女生产免费。\n企业：保护企业公司，国家股份一半，防止掏空。\n婚姻：25岁未婚，由政府配婚，落实工作权、生命权、婚姻权。\n农业：农产品产销失调，由政府合理价格收购。\n弱势群体：优先照顾弱势、残障，拼经济、拼外销。");
        linguolong.Add("政治经历", "华兴制药股份有限公司外务\n井田製药工业股份有限公司外务\n第二届立法委员竞选人\n中华民国国际贸易协会台北市进出口商业同业公会国际贸易实务结业。\n中华民国国际贸易协会国际贸易英文函牍讲习班结业。\n ");

        people.Add("林国龙", linguolong);

        Dictionary<string, string> huangminhui = new Dictionary<string, string>();
        huangminhui.Add("地区", "嘉义市");
        huangminhui.Add("党派", "国民党");
        huangminhui.Add("选举主张", "经济：落实「经济 5+1」政策。\n旅游：振兴嘉义市观光产业，推动补助观光客来嘉义市旅游消费计画。\n生活：开发嘉义信义区，引进大型OUTLET。推动电子支付。兴建嘉义市\n图书总馆和西区国民运动中心。完善嘉义市立美术馆。解决文化路商圈停车问题。\n养老：推动长照 2.0 计画，打造健康老化、在地安老。\n教育：逐年降低班级学生数，提高教师编制数，培养具国际竞争力的人才。");
        huangminhui.Add("两岸观点", "黄敏惠说，从2008年国民党执政以来，一直坚持九二共识，而两岸人民也期盼两岸间能繁荣和发展，在这样的政治基础之下，两岸关系才能推动，能有这样的成果得来不易，她呼吁蔡英文顾虑到大家的心情，两岸和平发展是大家共同的期待。");
        huangminhui.Add("政治经历", "中山女高教師，第三屆國大代表\n第四、五、六屆立法委員\n第七、八屆嘉義市市長\n中華民國智障者體育運動協會理事長\n嘉義市社區大學發展協會理事長\n嘉義市商業會榮譽理事長\n財團法人中正大學學術基金會董事\n救國團指導委員\n中國國民黨副主席、代理主席 ");

        people.Add("黄敏惠", huangminhui);


        Dictionary<string, string> tuxingzhe = new Dictionary<string, string>();
        tuxingzhe.Add("地区", "嘉义市");
        tuxingzhe.Add("党派", "民进党");
        tuxingzhe.Add("选举主张", "水利：持续兴建雨水下水道，打造海绵城市，彻底解决淹水问题。\n城建：建构兰潭风景区4米自行车道与景观步道工程。完成「绿园道」道将圳水岸景观、「水园道」维新路水岸景观工程。打造北栋市政大楼为嘉义新地标、市民中心。\n旅游：设置林业铁道文化黄金观光廊道，全面带动嘉义市观光产业。\n养老：推动老而健康、老有所用的城市。");
        tuxingzhe.Add("政治经历", "台北市政府卫生局局长\n行政院卫生署疾病管制局局长\n行政院卫生署署长\n总统府国策顾问\n第七届立法委员\n嘉义市市长 ");

        people.Add("涂醒哲", tuxingzhe);

        Dictionary<string, string> huangshufen = new Dictionary<string, string>();
        huangshufen.Add("地区", "嘉义市");
        huangshufen.Add("党派", "无");
        huangshufen.Add("选举主张", "就业：开发推动工商产业发展，提升就业机会、带动经济繁荣。\n环保：建置现代化、科技化的环保设施。\n文化：推动历史古蹟文物的建置与认证、艺文活动的活络与推广。\n教育：加强学童乡土教学并提升国际视野、伦理观念，建构全人教育体制，培养五育并重的人才。\n弱势群体：强化弱势族群社会关怀，辅导学习技能，协助自立谋生。\n养老：开办84里「幸福食堂」老人共餐，敬老爱家守护专案。\n住房：自用住宅房屋税、地价税减免。\n旅游：打造观光景点，提振观光经济产值。\n族群：设立新住民、平地原住民专责服务单位。\n农业：推动农业发展，增加农民收益；开授课程提升农民专业技能。");
        huangshufen.Add("政治经历", "现任嘉义市议会 议长\n嘉义市农会 总干事 \n第三届国民大会 国大代表\n嘉义大学EMBA口试委员\n中国文化大学博士班");

        people.Add("黄淑芬", huangshufen);
        
        Dictionary<string, string> huanghongcheng = new Dictionary<string, string>();
        huanghongcheng.Add("地区", "嘉义市");
        huanghongcheng.Add("党派", "无");
        huanghongcheng.Add("政治经历", "第四届国大代表候选人\n2014嘉义县长候选人\n2016嘉义市立委候选人\n ");

        people.Add("黄宏成", huanghongcheng);

        Dictionary<string, string> suqingquan = new Dictionary<string, string>();
        suqingquan.Add("地区", "屏东县");
        suqingquan.Add("党派", "国民党");
        suqingquan.Add("选举主张", "整体主张：强化交通，全力拼经济，强化社会福利，强化屏东医疗与长照系统，改善环境问题，强化教育与文化，强化水利与国土规划。");
        suqingquan.Add("两岸观点", "苏清泉接受中评社访问表示，两岸终究要统一，只是哪时候统一不知道，统一后要用什么名字还得靠下一代或这一代的智慧。在此之前他希望台湾经济可以更繁荣更好，尤其国台办日前公布31项对台措施将对两岸融合更具效果，不管就学、就医、就养、就业，都能进一步加强。");
        suqingquan.Add("政治经历", "安泰医疗社团法人安泰医院创院院长\n中国国民党第20届中央委员\n中国国民党第八届立法委员\n中国国民党政策会副执行长\n中国国民党屏东县党部主委\n中华民国区域医院协会理事长\n台湾私立医疗院所协会理事长\n中华民国医师公会全国联合会理事长\n ");

        people.Add("苏清泉", suqingquan);
        
        Dictionary<string, string> panmengan = new Dictionary<string, string>();
        panmengan.Add("地区", "云林县");
        panmengan.Add("党派", "民进党");
        panmengan.Add("选举主张", "整体主张：推动屏东好交通，深化全人照顾，打造城市文化风韵，实践安全宜居环境，创造屏东产业优势环境，教育优先、体育领航。");
        panmengan.Add("两岸观点", "潘孟安指出，过去自己赴大陆，是好奇心使然，而今两岸基层交流是趋势不可逆转。“尤其两岸城市之间的交流，民众之间的交流，更是大势所趋。”潘孟安说，他若有机会带领屏东地方团队，未来将透过各方面努力，加强屏东与大陆各城市之间的交流。");
        panmengan.Add("政治经历", "屏东县车城乡乡民代表\n第14、15届议员\n第6、7、8届立法委员\n第17届屏东县县长");

        people.Add("潘孟安", panmengan);

        Dictionary<string, string> lirongren = new Dictionary<string, string>();
        lirongren.Add("地区", "屏东县");
        lirongren.Add("党派", "无");
        lirongren.Add("选举主张", "1.支持爱家公投无色崛起\n2.建立屏东自治全民参政委员会每乡镇代表二人\n3.建立屏东绿能农业发展农业4.0\n4.建立屏东观光运动产业国际化\n5.建立屏东探索教育产业国际化\n6.建立屏东农特产品产业国际化大型交易博览会\n7.建立屏东长照旅居式国际养生村");
        lirongren.Add("两岸观点", "李镕任曾强调自己反对“台独”的立场，他喊话岛内民众，应该清楚这些年来台湾各领域几乎要崩盘了，“两岸同属一个中国，而我们的根源就是中华民族”。对于岛内现状和两岸关系，李镕任更是认为，台湾已经没有本钱再消耗下去，而且台湾不应该缺席大陆“一带一路”的商机。他同时喊话民进党当局，承认”九二共识“，为台湾谋未来。");
        lirongren.Add("政治经历", "世界商务促进会台湾总会荣誉总会长。\n中华全球华侨总会理事长。\n台湾区绿能作物运销合作社理事主席。\n华夏科技整合联合总会常务理事。\n朝阳科技大学应用化学农业科技研习班。");

        people.Add("李镕任", lirongren);

        Dictionary<string,string> raoqingling = new Dictionary<string, string>();
        raoqingling.Add("地区", "台东县");
        raoqingling.Add("党派", "国民党");
        raoqingling.Add("选举主张", "整体主张：秉持民众第一、服务至上、传承创新、县民参与的施政理念。以打造美景城乡、建立更宜居城市为施政目标全力达成观光城乡、幸福家园的施政愿景。并提出观光领航、农业创富、经济创能、文化加值、教育翻转、社福关怀六大施政主轴及其对应策略。");
        raoqingling.Add("政治经历", "现任台东县议会议长2009～2018\n现任台东县体育会理事长\n台东县议会副议长\n全国铁人三项委员会副理事长\n国立台东大学兼任助理教授\n北台科学技术学院专任讲师\n台东县2006～2007青工总会长\n台湾青年菁英协会2006～2007东区连络人\nKMT青年问政联盟2007～2008执行长");
    
        people.Add("饶庆玲", raoqingling);

        Dictionary<string, string> liuquanhao = new Dictionary<string, string>();
        liuquanhao.Add("地区", "台东县");
        liuquanhao.Add("党派", "民进党");
        liuquanhao.Add("选举主张", "整体主张：文化立县，友善农业，新创基地，南岛首都。");
        liuquanhao.Add("政治经历", "法官\n副县长\n律师\n第8、9届立法委员");

        people.Add("刘权豪", liuquanhao);

        Dictionary<string, string> pengquanguo = new Dictionary<string, string>();
        pengquanguo.Add("地区", "台东县");
        pengquanguo.Add("党派", "无");
        pengquanguo.Add("选举主张", "整体主张：施政重点：创新教育理念、整合医疗资源、简化行政流程、坚持财政纪律、建立政治文化、鼓励青年返乡（移居）、维护生态资源，让我们找回身为台东人的初衷。");
        pengquanguo.Add("政治经历", "第 14、15届台东县长参选人 \n台东圣母医院药师 \n卫福部台东医院药师");

        people.Add("彭权国", pengquanguo);

        Dictionary<string,string> huangyubin = new Dictionary<string, string>();
        huangyubin.Add("地区", "台东县");
        huangyubin.Add("党派", "无");
        huangyubin.Add("选举主张", "生医农业：应用台东独特都兰山地质矿物，圣山幽谷环境，栽种有机中药植物。\n地热资源：应用台东丰富地热，发展绿能发电、观光休閒养身事业，广增财源。\n海洋资源：应用优势的海岸线和天然水资源，发展科技水产养殖业。");
        huangyubin.Add("政治经历", "亚洲水泥公司工程師 \n台湾玉石公司董事长");

        people.Add("黄裕斌", huangyubin);

        Dictionary<string, string> kuanglizhen = new Dictionary<string, string>();
        kuanglizhen.Add("地区", "台东县");
        kuanglizhen.Add("党派", "无");
        kuanglizhen.Add("选举主张", "经济永续：1扩大观光与文化整合。2推动娱乐产业国际化。3提升有机农业规模化。\n社会永续：1推动永续生命教育。2加强在地人才培育。3推动医疗照护体系。\n环境永续：1强化灾害监测、防治。2推动建立生态城乡网。3建构绿色人本交通网。");
        kuanglizhen.Add("政治经历", " 1987就职中华航空公司空服员\n2005就职第15届台东县县长\n2014就职创立生物科技股份有限公司董事长");

        people.Add("邝丽贞", kuanglizhen);

        Dictionary<string, string> xuzhenwei = new Dictionary<string, string>();
        xuzhenwei.Add("地区", "花莲县");
        xuzhenwei.Add("党派", "国民党");
        xuzhenwei.Add("选举主张", " 1.建置智慧交通网路，强化花莲绿能永绩\n2.打造城市美学，推动廊带绿景、花园城市\n3.幸福花莲再升级，活力健康向前走\n4.营造乐活有机慢城，辅导青年返乡就业\n5.健全长照服务体系，长照健康智慧化\n6.厚植青少年教育学习、创意竞争能力\n7.深耕部落，文化优先，培育原住民人才\n8.新住民，馨活力");
        xuzhenwei.Add("政治经历", " 第九届立法委员\n中国国民党第二十届中央常务委员\n2016朱立伦总统选举花莲竞选总部主委\n国际崇她花莲社社长\n国际莲花狮子会会长\n救国团花莲团委会主委\n花莲县巡守大队大队长\n花莲县消防局妇女防火宣导大队大队长\n花莲县儿童照护暨家庭成长协会理事长");

        people.Add("徐榛蔚", xuzhenwei);

        Dictionary<string,string> liuxiaomei = new Dictionary<string, string>();
        liuxiaomei.Add("地区", "花莲县");
        liuxiaomei.Add("党派", "民进党");
        liuxiaomei.Add("选举主张", " 1.社福新愿景，温暖大花莲 \n2.畅通便捷大花莲 \n3.打造国际观光新乐园\n 4．安全大花莲，提高警察消防人员加给 \n5.为孩子安上梦想的翅膀 \n6.企业安心投资经商、力拚招商好成绩");
        liuxiaomei.Add("政治经历", " 第九届立法委员\n中国国民党第二十届中央常务委员\n2016朱立伦总统选举花莲竞选总部主委\n国际崇她花莲社社长\n国际莲花狮子会会长\n救国团花莲团委会主委\n花莲县巡守大队大队长\n花莲县消防局妇女防火宣导大队大队长\n花莲县儿童照护暨家庭成长协会理事长");

        people.Add("刘晓玫", liuxiaomei);
       
        Dictionary<string, string> huangshipeng = new Dictionary<string, string>();
        huangshipeng.Add("地区", "花莲县");
        huangshipeng.Add("党派", "无");
        huangshipeng.Add("选举主张", " 1改革县政\n刘家有女觅封侯’晓谕花莲会更优\n玫梦欲成唯改革’推行新政放头筹。\n2展望花莲\n徐图渐进列诸侯’榛薄花莲待变优\n蔚蔚苍苍灵气地’文明整洁共高楼\n3.繁荣文明\n深绿深蓝深积怨’好山好水好无聊(奈)。\n能赢放弃美国籍’盛世文明信不遥。");
        huangshipeng.Add("政治经历", " 旅美作家，公司负责人\n台湾广泛面制度改革的推动者及理论先驱");

        people.Add("黄师鹏", huangshipeng);

        Dictionary<string, string> laifengwei = new Dictionary<string, string>();
        laifengwei.Add("地区", "澎湖县");
        laifengwei.Add("党派", "国民党");
        laifengwei.Add("选举主张", " 1.推动澎湖医疗在地化\n2．渔民生计与海洋生态求取平衡，并捍卫渔业主权。\n3.航空公司提升便利性及机动性。\n4.加速台华轮汰旧换新。\n5.开辟观光直航，拓展客源。\n6.打造澎湖艺术村，支持青年文创创业。\n7.设立澎湖美食街，营造舒适用餐环境，提升餐飮品质。\n8.花火节转型。\n9.增设海水淡化厂，设置中水回收系统，汰换老旧管线，解决用水问题。\n10.设置海洋科技园区，鼓励业者进驻，吸引青年返乡。\n11.整合县府、工策会及业界等资源，辅导传统产业升级。\n12.设立青年创业孵化器，协助创业咨询、资金取得，活络閒置空间，升级为共享工场。\n13从源头减量、建立清理机制、运用科技著手解决海漂垃圾。\n14.建构自主的垃圾处理能力，技术处理在地垃圾。\n15迁移活化市区土地，增建停车场。\n16.精进墓政，持续迁墓，并依需求扩建纳骨塔。\n17.扩大植树造林。\n18.就读公立幼儿园免学费，设立幼儿园补助，增设公共托育中心及公立幼儿园。\n19.兴建社会住宅，提供租金优惠。\n20.打造乐龄养生村，结合政府、民间资源，引进高品质医疗及完善生活照护。\n");
        laifengwei.Add("两岸观点", "赖峰伟表示希望借岸妈祖祈安法会进一步加深两岸民众的情感联系，推动和拓展澎湖和泉州两地乃至两岸文化、旅游、商贸等领域的交流合作。");
        laifengwei.Add("政治经历", "行政院原子能委员会科长\n中国国民党澎湖县委员会主任委员\n澎湖县政府（第13届）县长\n澎湖县政府（第14届）县长\n中国国民党高雄市委员会副主任委员\n内政部政务次长\n总统府副秘书长\n考试院考选部部长\n神脑国际董事长\n詹启贤党主席竞选办公室总监\n澎湖县政府（第18届）县长");

        people.Add("赖峰伟", laifengwei);

        Dictionary<string, string> chenguangfu = new Dictionary<string, string>();
        chenguangfu.Add("地区", "澎湖县");
        chenguangfu.Add("党派", "民进党");
        chenguangfu.Add("选举主张", " 1. 敬老金每年一万元。幼儿免学费降至2岁。加强日照、长照及居家服务。广佈社区照顾关怀据点与公共托育。\n2. 加速污水下水道工程。中央补助紧急救难船。道路共同管沟路平专案。\n3. 开发社区特色差异化旅游市场。点亮洁湖计画丰富澎湖夜景。发展澎南滨海观光廊带。新台华轮完»入营运。\n4. 种苗放流、珊湖种植及投放鱼礁。内湾海域水质改善。建海水淡化厂涵养地下水。垃圾处理在地化。\n5. 澎防部与澎指部迁移规划军事文化游憩园区。大专生助学金二万元。建白沙多功能体育馆。历史文化资产修复与活化。\n6. 知名教学医院设立分院。医疗策略联盟广度补足专科医生。卫生室扩建整修与升格。引进高端医疗设施。");
        chenguangfu.Add("两岸观点", "陈光复作为“登陆”访问的7名民进党返台后，民进党内一部分人批评他“走得太快了”。陈光复称：虽然承受压力，但时代在改变，必须要走出去与大陆交流，“误解降低，才能往进步与和平的路上走”。");
        chenguangfu.Add("政治经历", "民进党中执委、全国党代表、高雄市党部主委\n高雄市议员\n立法委员\n民进党澎湖县党部主委\n澎湖县县长");

        people.Add("陈光复", chenguangfu);

        Dictionary<string, string> wuzhenglong = new Dictionary<string, string>();
        wuzhenglong.Add("地区", "澎湖县");
        wuzhenglong.Add("党派", "无");
        wuzhenglong.Add("选举主张", "整体主张：三大优先爲施政主轴经济优先、环境优先、建设优先。");

        people.Add("吴政隆", wuzhenglong);

        Dictionary<string,string> zhengqingfa = new Dictionary<string, string>();
        zhengqingfa.Add("地区", "澎湖县");
        zhengqingfa.Add("党派", "无");
        zhengqingfa.Add("选举主张", "一、 规划观光缆车及内海游憩网，定期密集处理海漂废弃物。\n二、 免健保费扩大至55岁以上，补助中低收入户65岁以上长者装置假牙。\n三、 编列预算聘次专科医疗团队常驻，提昇医疗品质。\n四、 建置高科技焚化炉解决垃圾问题，进行绿手指计画奖励植树造林。\n五、 改善校园学习环境，增置国中小教室冷气设备，电费由县府编列。\n六、 观光加値，营造社区特色，推动深度旅游。\n七、 推广精緻农业，打造新农村；发展渔、业生计及海洋水资源产业。\n八、 支持青年返乡创业，提供微创基金，活络地方经济。\n九、 增加老、幼托育养机构，培训中高龄人力资源导入常照及老年社区照护。\n十、利用閒置空间设立文艺村，邀请作家、艺术家进驻，提供文艺创作讲座、展演。");

        people.Add("郑清发", zhengqingfa);

        Dictionary<string, string> luhuayuan = new Dictionary<string, string>();
        luhuayuan.Add("地区", "澎湖县");
        luhuayuan.Add("党派", "无");
        luhuayuan.Add("选举主张", "―、盘点在地资源，拟定未来五年澎湖经济产业白皮书。\n二、积极争取设计展览活动等在澎湖举办。\n三、创立「逾湖大海艺术祭」。\n四、成立「国际澎湖旅外乡亲协会」。\n五、审愼评估扩大澎湖海洋养殖区，引进新技术。\n六、成立澎湖观光智隳团。\n七、建构澎湖成爲海洋技职教育大本营。\n八、提升澎湖医卫水平，巩固在地医疗信服务。");

        people.Add("吕华苑", luhuayuan);
       
        Dictionary<string,string> chendasong = new Dictionary<string, string>();
        chendasong.Add("地区", "澎湖县");
        chendasong.Add("党派", "无");
        chendasong.Add("选举主张", "整体主张：以大思维，大方向，大建设，大未来等四大主轴，确立澎湖「世界尚介美，全国最大县(海域)」的优势地位。");

        people.Add("陈大松", chendasong);

        Dictionary<string,string> wengzhensheng = new Dictionary<string, string>();
        wengzhensheng.Add("地区", "澎湖县");
        wengzhensheng.Add("党派", "无");
        wengzhensheng.Add("选举主张", "整体主张：与县民合作联手打造的明珠般宜居岛屿。水、电、交通、垃圾、污水等实在基础落实与生活品质提昇。");
        wengzhensheng.Add("政治经历", "灵狮广告公司资讯部主任\n和信传播集团电子商务部主任\n哈网财经网站研发部经理\nLaTour 旅游网发行人\n潮间带渔业\n台东大桥部落课辅老师\n孩子的书屋产业经理人\n海洋公民基金会执行长\n爱海的旅行负责人");

        people.Add("翁珍圣", wengzhensheng);

        Dictionary<string, string> yangzhenwu = new Dictionary<string, string>();
        yangzhenwu.Add("地区", "金门县");
        yangzhenwu.Add("党派", "国民党");
        yangzhenwu.Add("选举主张", "主要观点：从廉能政府，土地安居，教育文化，永续环保，开创新局，产经繁荣，医疗照护。几方面整治。");
        yangzhenwu.Add("两岸观点", "针对大陆国家主席习近平在今天的《告台湾同胞书》40周年谈话中指出，大陆可以优先与金门马祖来通水、通电、通桥、通气，金门县长杨镇浯表示，金门有条件做两岸发展的桥梁，也愿意做为两岸和平交流的先锋，这样的一个谈话方向，非常符合金马人民的期待，同时也有助于两岸进一步的和平交流。");
        yangzhenwu.Add("政治经历", "金门县政府机要秘书\n金门县政府交通旅游局专员、局长\n金门县政府观光处处长\n中国国民党大陆事务部副主任\n第九届立法委员");

        people.Add("杨振武", yangzhenwu);

        Dictionary<string, string> hongzhiheng = new Dictionary<string, string>();
        hongzhiheng.Add("地区", "金门县");
        hongzhiheng.Add("党派", "金门高粱党");
        hongzhiheng.Add("选举主张", " 设金门代中央还债建设金门基金\n鼓励两岸青年来金门实现梦想\n零排碳自主发电\n公开透明(媒体全程转播)广纳贤才");
        hongzhiheng.Add("政治经历", "法律事务经历24年");

        people.Add("洪智恒", hongzhiheng);

        Dictionary<string, string> wangchenghua = new Dictionary<string, string>();
        wangchenghua.Add("地区", "金门县");
        wangchenghua.Add("党派", "教科文预算保障e联盟");
        wangchenghua.Add("选举主张", " 1.交通发展\n2.宜居城市\n3.医疗平台\n4.司法平台\n5.世界遗产\n6.经济提升\n7.民主政治\n8.新闻自由");
        wangchenghua.Add("两岸观点", "两岸共治");
        wangchenghua.Add("政治经历", "佛教文化艺术协会理事长\n养生休閒保健协会金门分会会长\n教科文联盟党荣誉主席\n浙江诸暨市同乡会理事\n世界和平基金会上海分会副会长\n海峡两岸交流联合总会文化传播交流会会长兼发言人\n台湾全方位资深媒体人，作家，广电製作主持人\n上海移居上海杂志总编辑、两岸商旅杂志主笔，北京当代中国记者主任");

        people.Add("王成华", wangchenghua);

        Dictionary<string, string> chenfuhai = new Dictionary<string, string>();
        chenfuhai.Add("地区", "金门县");
        chenfuhai.Add("党派", "无");
        chenfuhai.Add("选举主张", "政见主轴：幸福金门，跃升成真\n施政目标：实现金门幸福愿景，打造浯岛美丽家园\n五大愿景：两岸枢纽、优质乐活、文化富裕、生态永续、观光休息");
        chenfuhai.Add("两岸观点", "金门县县长陈福海14日接受《旺报》专访表示，台湾人称金门是「福建金门」，大陆人则称「台湾金门」，但其实金门应是「两岸金门」，从1990年签署《金门协议》、2001年小三通启航、今年5月的夏张会到即将签署引水协议，皆一再证明「立足金门，连结两岸」从来就不是口号，而是每天都在发生的事。");
        chenfuhai.Add("政治经历", "金门县金湖镇民代表\n金门县议员\n金门县金湖镇长\n立法委员\n金门县县长");

        people.Add("陈福海", chenfuhai);

        Dictionary<string, string> xieyizhang = new Dictionary<string, string>();
        xieyizhang.Add("地区", "金门县");
        xieyizhang.Add("党派", "无");
        xieyizhang.Add("选举主张", " 1.四年500亿经济招商计划。\n2.金酒自建行销通路网；目标1000家自营店。\n3.推动青年3000人就业职训与辅导。\n4.增加老人年金与医疗就养计划。\n5.扩大闽南式古厝建筑的补助。\n6.四年五乡镇社会福利平价国宅3000户。\n7.推展一村一特色的产业辅导与投资。\n8.强化教育资源的垂直整合。\n9.设立青年养家失业保障机制。\n10.健全农林渔牧的精緻均衡发展。");
        xieyizhang.Add("两岸观点", "谈及泉金航线与厦金航线的市场关系时，谢宜璋认为，它们之间应该是一种相互的良性竞争，这样才能有更好的更广泛的交流合作。");
        xieyizhang.Add("政治经历", "金门县议会第二届议员\n金门县议会第三届议员\n金门县议会第四届议长");

        people.Add("谢宜璋", wangchenghua);

        Dictionary<string, string> honghecheng = new Dictionary<string, string>();
        honghecheng.Add("地区", "金门县");
        honghecheng.Add("党派", "无");
        honghecheng.Add("选举主张", " 1.广阔青年合宜住宅，实践青年居住正义\n2.简化提高失业补助金，实践全民基本收入\n3.开闢沙美小三通第二码头，浯江轮渡公司加入营运\n4.争取设立金门和平经贸特区\n5.小学、幼稚园提早半个小时放学，学校负责接送");
        honghecheng.Add("政治经历", "領新電子有限公司负责人");

        people.Add("洪和成", honghecheng);

        Dictionary<string, string> liuzengying = new Dictionary<string, string>();
        liuzengying.Add("地区", "连江县");
        liuzengying.Add("党派", "国民党");
        liuzengying.Add("选举主张", " 1.落实离岛综合建设五期及十二年中长程发展计画，为地方创生奠定永续发展根基。\n2.赓续争取兴建南北竿跨海大桥，加强基础设施，提升乡亲生活品质，因应产业经济发展需求。\n3.加速改善机场，兴建三仟吨以上离岛客货轮。\n4.兴建现代化运动中心及演艺场馆，举办各类体育竞赛及艺文活动。\n5.落实在地文化保存工作，转化马祖史蹟为两岸独特艺术形态，打造成为国际艺术岛。\n6.强化医疗设施，发展智慧医疗，\n7.加强弱势群体等照顾及发展机会。\n8.延续社会暨示范住宅政策，提供乡亲住宅需求。\n9.推动高等教育进驻，培养专业人才。\n10.重视劳工权益，友善劳动环境。\n11.加速完成全县土地登记及都市计划通盘检讨。\n12.重视环境及海洋生态永续。\n13.连结两岸地缘优势，加强经贸交流合作。\n14.推动马酒扩厂计划。\n15.发展各乡特色，推动以自然生态。\n16.推动区域联合治理，\n17.推动智慧城乡\n19.积极加入慢城等国际认证。\n20.以健康岛屿·幸福马祖。");
        liuzengying.Add("两岸观点", "“我们非常支持两岸‘应通尽通’。”刘增应表示，加速经贸交流，实现马祖与福建通水、通气、通电、通桥都是未来的目标，马祖民众乐观其成；现阶段更务实、更积极的做法是落实经贸、交通交流，为通水、通气、通电、通桥奠定一个很好的基础。");
        liuzengying.Add("政治经历", "连江县第6届县长\n连江县卫生局局长\n连江县县立医院院长\n连江县县立医院医师\n中华民国内科专科医师\n中华民国家庭医学科专科医师");

        people.Add("刘增应", liuzengying);

        Dictionary<string, string> subohao = new Dictionary<string, string>();
        subohao.Add("地区", "连江县");
        subohao.Add("党派", "树党");
        subohao.Add("选举主张", "主要观点：长期一直关注的海洋资源保育议题，主张设置近岸限渔区与永久禁渔区，交通上也希望能够解决目前资源配置不均的问题，希望联合离岛县向中央争取离岛居民票补助从30%~50%。针对合宜住宅价格过高的问题主张调降售价，并且提出设违建落日条款阻止新违建出现，透过「容积转移」、「容积代金」辅导既存违建合法化。");
        subohao.Add("政治经历", "树党连江县党部主委\n树党行销长\n树党中执委\n台湾树人会理事\n公民记者(豪猪)\n电脑公司创业人");

        people.Add("苏铂豪", subohao);

        Dictionary<string, string> weiyaogan = new Dictionary<string, string>();
        weiyaogan.Add("地区", "连江县");
        weiyaogan.Add("党派", "无");
        weiyaogan.Add("选举主张", "设县民创业免息担保基金法人\n推「马祖列岛自由港区自治条例」\n 促成2020年前两岸谈判「蔡习会」在马祖\n催生马祖高度自治立法，成两岸缓衝「和平特区」\n力争故宫文物移置马祖北竿及执政府院党南竿便民中心\n创办官民合营马祖银行，引进外资国际银行\n筹设马祖医学大学及医学中心\n突破一派独大的县政团队，杜绝特权分赃。\n打破马祖酒厂特权垄断、释股/分红县民、配售酒价调降。整顿台马轮/台马之星缺失，筹办夜航，达成县内东引、莒光等四乡城一日生活圈。\n扩建机场、增闢国际线、缔结姊妹县，吸引国际游客。\n比照澎湖列屿及兰屿、绿岛，增建东引、莒光机场。\n彻底解决房地产权历史不义纠葛。");
        weiyaogan.Add("政治经历", "两届立法委员(国防/外交委员会召集委员)\n牙医师公全国总会秘书长\n高雄市政府副秘书长\n ");

        people.Add("魏耀干", weiyaogan);

        Dictionary<string, string> zhuxiuzhen = new Dictionary<string, string>();
        zhuxiuzhen.Add("地区", "连江县");
        zhuxiuzhen.Add("党派", "无");
        zhuxiuzhen.Add("选举主张", "主要观点：从廉能政府，法治社会，乐利民生三方面治理连江县。");
        zhuxiuzhen.Add("政治经历", "连江县自来水厂副厂长\n营建署城乡发展分署\n台北县政府城乡发展局\n都市计画技师\n ");

        people.Add("朱秀珍", zhuxiuzhen);

        Dictionary<string, string> xieligong = new Dictionary<string, string>();
        xieligong.Add("地区", "基隆市");
        xieligong.Add("党派", "国民党");
        xieligong.Add("选举主张", " 1. 和中央密切合作，加速推动基隆市港重大建设\n2. 打造现代新颖的基隆城际转运站\n3. 发展东亚国际邮轮营运中心\n4. 再造中正公园\n5. 完成大基隆历史场景计画\n6.推动基隆产业转型，创造新就业机会\n7. 推动历史街区地方创生\n8. 闢建大武崙森林运动公园\n9. 推动实践路示范道路计画，加强控管管线单位工程\n10. 规划增闢城际快捷公车路线\n11. 加强客服训练\n12. 提升餐饮服务品质\n13. 改善河水质，营造优质亲水环境\n14. 改造暖东苗圃成为生态教育中心园区\n15. 加速长照2. 0佈建升级，扩大照顾老者及弱势\n16. 打造校园数位学习环境\n17. 改善体育馆及田径场设施，增设各区风雨球场空间");
        xieligong.Add("两岸观点", "谢立功并不希望看到两岸关系往两个极端去发展，两岸关系应该走向双方都可接受的路线，“一中各表”是最折衷的论述，不要太坚持意识形态。");
        xieligong.Add("政治经历", "基隆市第十七届市长\n行政院院长室参议\n总统府秘书室专门委员\n民进党主席特别助理兼办公室主任\n民进党中央党部发言人\n民进党第十二届中央执行委员\n民进党第十八届中央常务委员\n台湾城市竞争力发展协会理事长\n基隆市林姓宗亲会理事长");

        people.Add("谢立功", liuzengying);

        Dictionary<string,string> linyouchang = new Dictionary<string, string>();
        linyouchang.Add("地区", "基隆市");
        linyouchang.Add("党派", "民进党");
        linyouchang.Add("选举主张", " 1. 和中央密切合作，加速推动基隆市港重大建设\n2. 打造现代新颖的基隆城际转运站\n3. 发展东亚国际邮轮营运中心\n4. 再造中正公园\n5. 完成大基隆历史场景计画\n6.推动基隆产业转型，创造新就业机会\n7. 推动历史街区地方创生\n8. 闢建大武崙森林运动公园\n9. 推动实践路示范道路计画，加强控管管线单位工程\n10. 规划增闢城际快捷公车路线\n11. 加强客服训练\n12. 提升餐饮服务品质\n13. 改善河水质，营造优质亲水环境\n14. 改造暖东苗圃成为生态教育中心园区\n15. 加速长照2. 0佈建升级，扩大照顾老者及弱势\n16. 打造校园数位学习环境\n17. 改善体育馆及田径场设施，增设各区风雨球场空间");
        linyouchang.Add("两岸观点", "林右昌说，在两岸关系上台湾有几个底线。他说：“第一个、绝对不接受共产党的统治；第二个、要维持现在自由人权民主的价值和生活方式；第三、台湾人民不要战争；第四、台湾人民希望有一个更好的经济发展和更繁荣的社会。”");
        linyouchang.Add("政治经历", "基隆市第十七届市长\n行政院院长室参议\n总统府秘书室专门委员\n民进党主席特别助理兼办公室主任\n民进党中央党部发言人\n民进党第十二届中央执行委员\n民进党第十八届中央常务委员\n台湾城市竞争力发展协会理事长\n基隆市林姓宗亲会理事长");

        people.Add("林右昌", linyouchang);

        Dictionary<string, string> linzimiao = new Dictionary<string, string>();
        linzimiao.Add("地区", "宜兰县");
        linzimiao.Add("党派", "国民党");
        linzimiao.Add("选举主张", "主要观点：任用专业、团队决策、无私领导之理念，推展宜兰县政。提出「东部经济廊带」之区域资源整合概念，带领宜兰观光、农业进军国际。");
        linzimiao.Add("两岸观点", "邱副主委强调，中共提出「习五条」推动两岸统一进程，对我国家安全造成重大挑战；对於林县长即将赴陆交流，邱副主委表示乐见其成，将持续与地方政府进行联系沟通，提供必要协助，以避免政治风险，获致交流实绩；并呼吁两岸交流以台湾利益为优先，中央地方共同维护国家主权与民众福祉。");
        linzimiao.Add("政治经历", " 佛光大学硕士班肄业\n第14、15、16届宜兰县议员\n第16、17届罗东镇长");

        people.Add("林姿妙", linzimiao);

        Dictionary<string, string> chenoupo = new Dictionary<string, string>();
        chenoupo.Add("地区", "宜兰县");
        chenoupo.Add("党派", "民进党");
        chenoupo.Add("选举主张", "主要观点：结合优秀文官，组成新政团队，以创新的思维，提出进步的新政，引领宜兰突破目前的困境。[以杂六大构面发展，实现「活力宜兰生活读」的共同愿景。");
        chenoupo.Add("政治经历", "立法委员(获9次优秀立委)\n台湾大学环境工程学博士候选人\n台湾与韩国、缅甸、柬埔寨、尼泊尔、印尼国会议员友好协会会长\n高考及格任林管处技术员\n县府课长、技正、秘书\n三星代乡长\n省议员\n县党部主委\n立法院党团副书记长\n立法院外交及国防、交通委员会召集委员");

        people.Add("陈欧珀", chenoupo);

        Dictionary<string, string> linxinhua = new Dictionary<string, string>();
        linxinhua.Add("地区", "宜兰县");
        linxinhua.Add("党派", "无");
        linxinhua.Add("选举主张", "从农业经济产业，海洋河川产业，交通建设1+1，社会治安落实，教育资源整合，预防医疗建置，银髮共生社区，三代同堂愿景，族群文化推广十个方面来治理。");
        linxinhua.Add("政治经历", "宜兰县副县长 \n台湾省谘议会谘议员 \n行政院政务顾问 \n佛光大学主秘、总务长、院长、 系主任");

        people.Add("林信华", linxinhua);

        Dictionary<string, string> chenqiujing = new Dictionary<string, string>();
        chenqiujing.Add("地区", "宜兰县");
        chenqiujing.Add("党派", "无");
        chenqiujing.Add("选举主张", "一、 开放农地无自宅的小农盖农舍。\n二、 前往北大拜访林毅夫先生。\n三、 因应少子化，推动教育资源整合，并与产业工会合作，推行职前练。\n四、 直接关闭污染无法防治的产业。\n五、 续推观光业，并引进农业生物科技及工具机业。\n六、 成立3D列印推广教育中心。\n七、 将杜区大学提升为宜兰、人文平台。\n八、 将选票补助款总金额及保证金二十万，全数捐给宜兰联合劝募基金会。");
        chenqiujing.Add("政治经历", "公务人员普通考试化学工程科（及格）\n国立宜兰大学\n经济部台湾自来水公司");

        people.Add("陈秋境", chenqiujing);

        Dictionary<string, string> linjinkun = new Dictionary<string, string>();
        linjinkun.Add("地区", "宜兰县");
        linjinkun.Add("党派", "无");
        linjinkun.Add("选举主张", "一、农民参政绝无金主与炒地皮及金钱买票。\n二、看仅公文、讣文，无女儿代决行公文、绝不到丧家闹场。\n三、绝不背骨忘恩负义，出卖青天、出卖团队。\n四、每年检讨施政满意度不够马上辞职。\n五、建议自2020年起选举，宜兰县民有出席投票者，每一投票人发给3600元做旅费薪资补贴，并建议修法投票日改在周日举办，并于周一补休，以三天连假方式施行。\n六、建议政府应予立法，今后选举不得于投票日前六个月有选举活动及行为，政党初选不得于八个月前。以免扰民及减少选举花费。\n七、施设北宜高铁+区间台铁接驳系统。\n八、施设宜兰直通桃园之高速公路。\n九、规钊交通成纵、横线并结合环状圈之连结，建置便捷宜兰交通网。铁路高架化前，以道路下挖、隧道穿越铁路方式，消除平交道。\n十、统一县内交通号志，列管改善危险道路及路口。\n十一、推动市场改建、都市更新、美化市容术景。\n十二、加速都市计划开发，促进地方繁荣。\n十三、宜兰县内空中览车之兴建规划；推行落实公墓公园化政策。\n十四、校园安全之建置、电脑化及影视敎学之建置，一学生一平板之配建，推动双语教学。\n十五、照顾妇幼。\n十六、提升宜兰医疗品质与水准。\n十七、老人食堂配合医疗徤检、文康活动、建立完善照护体制。\n十八、山脚道路全线完成。\n十九、行销小面积农地出租，增加宜兰农户所得。\n二十、有线电视全面降价。\n二十、一人一票抢救保证金。");
        linjinkun.Add("政治经历", "曾任宜兰县员山乡民代表");

        people.Add("林锦坤", linjinkun);

    }
}

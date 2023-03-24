using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using MySql.Data.MySqlClient;


namespace newonenetapp
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }
        private JArray jArray=new JArray();
        private string last_login = null;
        private string ok = null;
        //点击登入按钮事件
        private void enter_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            MySqlConnection conn = DataBase.getconn();
            //表device中只保存最新数据
            if(dataBase.query_device(conn,"device")>0)
            {
                
              int k=dataBase.delete_device(conn, "device");

            }
            //将设备情况预先储存到数据库
            string json = Request.discover_device();
            JArray jArray = JArray.Parse("[" + json + "]");
            //获得设备数量
            int device_count = Convert.ToInt32(jArray[0]["data"]["total_count"]);
            int i = 0;
            //遍历json数组获得各个设备的信息
            for(; i<device_count;i++)
            {
                int deviceid = Convert.ToInt32(jArray[0]["data"]["devices"][i]["id"]);
                string devicename = jArray[0]["data"]["devices"][i]["title"].ToString();
                string devicestatus = jArray[0]["data"]["devices"][i]["online"].ToString();
                string deviceprotocol = jArray[0]["data"]["devices"][i]["protocol"].ToString();
                string devicecreattime = jArray[0]["data"]["devices"][i]["create_time"].ToString();
                //尝试获取设备上次上线时间
                try
                {    //若设备从未上线则不存在上线时间则ok为空
                     ok = jArray[0]["data"][i]["last_login"].ToString();
                }
                catch
                {

                }
              
               //如果设备最近上线过就获取上线的时间
                if (ok!=null)
                {
                  last_login = jArray[0]["data"]["devices"][i]["last_login"].ToString();
                  ok = null;
                }
                
               
                //将数据插入到设备表
                dataBase.insert_device(conn, deviceid, devicename, devicestatus, deviceprotocol, devicecreattime);
                //只保留近七天的登录记录
                if (dataBase.query_device(conn, "loginhistory") > 7)
                {
                    dataBase.delete_device(conn, "loginhistory");
                }
                else
                {   
                    //如果线上时间不为空就存入数据库
                    if(last_login!=null)
                    {
                        //只存入不同的登录记录
                        if (dataBase.query_loginhistory(conn, "loginhistory", last_login) == 0)
                        {
                            dataBase.insert_loginhistory(conn, deviceid, last_login);
                            last_login = null;
                        }
                    }
                    

                }
            }
                   
           
            timer_start.Enabled = true;//定时器使能
            timer_start.Start();//开启定时器
            progressBarstart.Visible = true;
        }
        //加载页面预先完成的事件
        private void Start_Load(object sender, EventArgs e)
        {
            timer_start.Enabled = false;//定时器默认禁用
            progressBarstart.Visible = false;//隐蔽进度条
            timer_start.Interval = 200;//设定定时器事件间隔为100ms
            progressBarstart.Value = 0;//设置进度条默认为0
            progressBarstart.Maximum = 100;//设置进度条默认最大值为100
            progressBarstart.Step = 20;//每次增加20
          
        }
        //定时器事件
        private void timer_start_Tick(object sender, EventArgs e)
        {
            progressBarstart.PerformStep();//进度按预设值增加
            if (progressBarstart.Value == progressBarstart.Maximum)//进度完成
            {
                timer_start.Stop();//停止定时器
                timer_start.Enabled = false;
                Main main = new Main();
                main.Show();
                this.Hide();//隐藏start界面

            }
        }
        //测试按钮
        private void button_test_Click(object sender, EventArgs e)
        {
            Request request = new Request();
            string k = request.Discovery_MobileDevice_Data();
            textBox_test.Text = k.ToString();          


        }





    }
}


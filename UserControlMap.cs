using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newonenetapp
{
    public partial class UserControlMap : UserControl
    {
        public UserControlMap()
        {
            InitializeComponent();
        }
        private string Lon = null;
        private string Lat = null;
        private string temp=null;
        
        //定位按钮点击事件
        private void buttonLocate_Click(object sender, EventArgs e)
        {
            Request request = new Request();
            string json = request.Discovery_MobileDevice_Data();
            JArray jArray = JArray.Parse("[" + json + "]");
            //从onenet获取经纬度
            for(int i=0;i<3;i++)
            {
                try
                {
                    temp = jArray[0]["data"]["devices"][0]["datastreams"][i]["id"].ToString();

                }
                catch
                {


                }
                if(temp==null)
                {
                    continue;
                }
                else
                {
                    if(temp=="lat")
                    {
                        Lat=jArray[0]["data"]["devices"][0]["datastreams"][i]["value"].ToString();
                    }
                    else if(temp=="lon")
                    {

                        Lon= jArray[0]["data"]["devices"][0]["datastreams"][i]["value"].ToString();
                    }
                    temp = null;
                }
               
               
            }
            //将经纬度写入本地的html文件
            Html html = new Html();
            html.CreateHtml(@"C:\Users\七瑾\Desktop\sgt\c#\newonenetapp\newonenetapp\Html", "map.html",Lon,Lat);
            //通过浏览器控件展示
            webBrowserMap.Navigate(@"C:\Users\七瑾\Desktop\sgt\c#\newonenetapp\newonenetapp\Html\map.html");
        }

        private void UserControlMap_Load(object sender, EventArgs e)
        {

        }
    }
}

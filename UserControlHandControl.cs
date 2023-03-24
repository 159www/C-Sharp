using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;

namespace newonenetapp
{
    public partial class UserControlHandControl : UserControl
    {
        public UserControlHandControl()
        {
            InitializeComponent();
        }
        //预先加载
        private void UserControlHandControl_Load(object sender, EventArgs e)
        {
            //添加设备选项
            DataBase dataBase = new DataBase();
            MySqlConnection conn = DataBase.getconn();
            int length = dataBase.query_device(conn, "device");
            string[] DeviceName = dataBase.GetDeviceName(conn, "device", length);
            for(int i=0;i<DeviceName.Length;i++)
            {
                comboBoxDeviceSelect.Items.Add(DeviceName[i]);
            }

        }
        //选择设备后事件
        private void comboBoxDeviceSelect_SelectedValueChanged(object sender, EventArgs e)
        {
            //将对应设备的指令添加到指令框
            comboBoxCommand.Items.Clear();//清空原有记录
            DataBase dataBase = new DataBase();
            MySqlConnection conn = DataBase.getconn();
            int length = dataBase.query_device(conn, "cmd");
            string[] cmd = dataBase.GetDeviceCMD(conn, "cmd", comboBoxDeviceSelect.Text, length);
            for(int i=0;i<cmd.Length;i++)
            {
                comboBoxCommand.Items.Add(cmd[i]);

            }


        }
        //命令下发按钮点击事件
        private void buttonCommand_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            MySqlConnection conn = DataBase.getconn();
            //获得指令字符串
            string cmd = dataBase.DiscoveryDeviceCmd(conn, "cmd", comboBoxDeviceSelect.Text, comboBoxCommand.Text);
            //获得设备id
            int deviceid = dataBase.GetDeviceIdByDeviceName(conn, "device", comboBoxDeviceSelect.Text);
            //命令下发
            string json=Request.upload_command(cmd, deviceid.ToString(), "300");
            JArray jArray = JArray.Parse("[" + json + "]");
            string error = jArray[0]["error"].ToString();
            if(error=="succ")
            {
                MessageBox.Show("命令下发成功");
            }
            else
            {
                MessageBox.Show("命令下发失败");
            }
        }
        //添加命令按钮点击事件
        private void buttonAddCommand_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            MySqlConnection conn = DataBase.getconn();
            int flag = dataBase.AddCmd(conn, comboBoxDeviceSelect.Text,textBoxCmdName.Text,textBoxAddCommand.Text);
            if(flag>0)
            {
                MessageBox.Show("添加成功");

            }
            else
            {
                MessageBox.Show("添加失败");
            }


        }
    }
}

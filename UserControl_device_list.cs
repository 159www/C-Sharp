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
    public partial class UserControl_device_list : UserControl
    {
        public UserControl_device_list()
        {
            InitializeComponent();
        }
        //预先加载
        private void UserControl_device_list_Load(object sender, EventArgs e)
        {
            textBox_device_id.Visible = false;
            //把设备信息表中的数据加载到表格视图控件
            DataBase dataBase = new DataBase();
            MySqlConnection conn = DataBase.getconn();
            MySqlDataAdapter mySqlDataAdapter = dataBase.get_adapter_from_devie(conn, "device");
            DataSet dataSet = new DataSet();
            //将mySqlDataAdapter对象添加到ataSet中
            mySqlDataAdapter.Fill(dataSet, "device");
            //将控件的数据源设置为
            dataGridView_device_list.DataSource = dataSet.Tables["device"];
        }
        //点击添加设备按钮事件
        private void button_add_device_Click(object sender, EventArgs e)
        {
            Request request = new Request();
            string json=request.add_device(textBox_devicename.Text,richTextBox_device_describe.Text,textBox_author.Text);
            JArray jArray = JArray.Parse("[" + json + "]");
            string error = jArray[0]["error"].ToString();          
            string device_id = jArray[0]["data"]["device_id"].ToString();
            if(error=="succ")
            {   
                //显示设备id和提示添加设备成功
                textBox_device_id.Text = device_id;
                textBox_device_id.Visible = true;
                MessageBox.Show("添加成功");
                //更新设备表和datagridview控件
                Data data = new Data();
                data.update_device_table();
                //把设备信息表中的数据加载到表格视图控件
                DataBase dataBase = new DataBase();
                MySqlConnection conn = DataBase.getconn();
                MySqlDataAdapter mySqlDataAdapter = dataBase.get_adapter_from_devie(conn, "device");
                DataSet dataSet = new DataSet();
                //将mySqlDataAdapter对象添加到ataSet中
                mySqlDataAdapter.Fill(dataSet, "device");
                //将控件的数据源设置为
                dataGridView_device_list.DataSource = dataSet.Tables["device"];
            }



        }
        //点击删除设备按钮事件
        private void button_delete_device_Click(object sender, EventArgs e)
        {  
            //获取选中设备的设备id
            string device_id = dataGridView_device_list.SelectedRows[0].Cells[0].Value.ToString();
            if(device_id== "951993945")
            {
                MessageBox.Show("该设备不能删除");
            }
            else
            {
                //删除对应设备
                Request request = new Request();
                string json = request.delete_device(device_id);
                JArray jArray = JArray.Parse("[" + json + "]");
                string error = jArray[0]["error"].ToString();
                //删除成功则更新表和datagridview控件
                if (error == "succ")
                {
                    Data data = new Data();
                    data.update_device_table();
                    //把设备信息表中的数据加载到表格视图控件
                    DataBase dataBase = new DataBase();
                    MySqlConnection conn = DataBase.getconn();
                    MySqlDataAdapter mySqlDataAdapter = dataBase.get_adapter_from_devie(conn, "device");
                    DataSet dataSet = new DataSet();
                    //将mySqlDataAdapter对象添加到ataSet中
                    mySqlDataAdapter.Fill(dataSet, "device");
                    //将控件的数据源设置为
                    dataGridView_device_list.DataSource = dataSet.Tables["device"];
                    MessageBox.Show("删除成功");

                }
            }
           
           



        }
    }
}

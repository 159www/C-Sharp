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
    public partial class UserControl_device_datahistory : UserControl
    {
        public UserControl_device_datahistory()
        {
            InitializeComponent();
        }
        private string deviceid = null;
        private string value = null;
        private int index = 0;
        //点击筛选按钮事件
        private void buttonQuery_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DataBase.getconn();
            DataBase dataBase = new DataBase();
            //先清空数据历史表datahistory
            dataBase.delete_device(conn, "datahistory");
            Request request = new Request();
            //构造指定格式的时间字符串
            string StartTime = dateTimePicker_StartTime.Text.Replace(' ','T');
            string EndTime = dateTimePickerEndTime.Text.Replace(' ', 'T');
            string json = request.Discovery_device_DataHistory(deviceid, comboBoxDataStream.Text, StartTime, EndTime, numericUpDownDataNumber.Value.ToString());
            JArray jArray = JArray.Parse("[" + json + "]");
            if(jArray[0]["error"].ToString()=="succ")
            {
                while(true)
                {
                    try
                    {
                        value = jArray[0]["data"]["datastreams"][0]["datapoints"][index]["value"].ToString();
                    }
                    catch
                    {

                    }
                    if(value==null)
                    {
                        break;
                    }
                    else
                    {
                        string value = jArray[0]["data"]["datastreams"][0]["datapoints"][index]["value"].ToString();
                        string time= jArray[0]["data"]["datastreams"][0]["datapoints"][index]["at"].ToString();
                        string datastream = jArray[0]["data"]["datastreams"][0]["id"].ToString();
                        this.value = null;
                        index++;
                        dataBase.Insert_DataHistory(conn, "datahistory", datastream, value, time);

                    }




                }
                //更新ui
                MySqlDataAdapter adapter = dataBase.get_adapter_from_devie(conn, "datahistory");
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "datahistory");
                dataGridView_datahistory.DataSource = dataSet.Tables["datahistory"];


            }
          
        }
        //预先处理
        private void UserControl_device_datahistory_Load(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            MySqlConnection conn = DataBase.getconn();
            int length = dataBase.query_device(conn, "device");
            string[] DeviceName = dataBase.GetDeviceName(conn, "device", length);
            //将设备命添加到对应的combox
            for(int index=0;index<DeviceName.Length;index++)
            {
                comboBoxDeviceName.Items.Add(DeviceName[index]);

            }
            
        }
        //将设备对应的数据流添加到对应选择框
        private void comboBoxDeviceName_SelectedValueChanged(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            MySqlConnection conn = DataBase.getconn();
            //获得设备id
            int DeviceId = dataBase.GetDeviceIdByDeviceName(conn, "device", comboBoxDeviceName.Text);
             deviceid = DeviceId.ToString();
            //获取设备数据流个数
            int length = dataBase.GetDataStremNumbersByDeviceID(conn, "datastream", DeviceId);
            string[] DataStream = dataBase.GetDataStreamByDeviceId(conn, "datastream", DeviceId, length);
            //将设备对应的数据流添加到数据流选择框
            for(int index=0;index<DataStream.Length;index++)
            {
                comboBoxDataStream.Items.Add(DataStream[index]);
                 
            }
        }
    }
}

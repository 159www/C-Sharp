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

namespace newonenetapp
{
    public partial class UserControl_device_staus : UserControl
    {
        public UserControl_device_staus()
        {
            InitializeComponent();
        }
        //预先加载
        private void UserControl_device_staus_Load(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            MySqlConnection conn = DataBase.getconn();
            int length = dataBase.query_device(conn, "loginhistory");
            string[] X = dataBase.GetLoginTimeFromLoginHistory(conn, "loginhistory", length);
            int[] Y = new int[X.Length];
            for(int i=0;i<X.Length;i++)
            {
                Y[i] = 1;
            }
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -45;   //下方标签显示的角度
            chart1.Series[0].Points.DataBindXY(X, Y);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

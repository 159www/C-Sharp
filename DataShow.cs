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
    public partial class DataShow : Form
    {
        public DataShow()
        {
            InitializeComponent();
        }
        private UserControlHumity userControlHumity;
        private UserControlLight userControlLight;
        private UserControlMap userControlMap;
        private UserControlTemperture userControlTemperture;
        //预先加载
        private void DataShow_Load(object sender, EventArgs e)
        {
            userControlTemperture = new UserControlTemperture();
            userControlHumity = new UserControlHumity();
            userControlLight = new UserControlLight();
            userControlMap = new UserControlMap();
            userControlTemperture.Show();
            userControlHumity.Show();
            userControlLight.Show();
            userControlMap.Show();
            userControlTemperture.Visible = false;
            userControlHumity.Visible = false;
            userControlLight.Visible = false;
            userControlMap.Visible = false;
            panelShow.Controls.Add(userControlTemperture);
            panelShow.Controls.Add(userControlHumity);
            panelShow.Controls.Add(userControlLight);
            panelShow.Controls.Add(userControlMap);
        }
        //温度按钮点击事件
        private void buttonTemperture_Click(object sender, EventArgs e)
        {
            userControlTemperture.Visible = true;
            userControlHumity.Visible = false;
            userControlLight.Visible = false;
            userControlMap.Visible = false;

        }
        //湿度按钮点击事件
        private void buttonHumity_Click(object sender, EventArgs e)
        {
            userControlTemperture.Visible = false;
            userControlHumity.Visible = true;
            userControlLight.Visible = false;
            userControlMap.Visible = false;

        }
        //光强按钮点击事件
        private void buttonLight_Click(object sender, EventArgs e)
        {
            userControlTemperture.Visible = false;
            userControlHumity.Visible = false;
            userControlLight.Visible = true;
            userControlMap.Visible = false;
        }
        //位置按钮点击事件
        private void buttonMap_Click(object sender, EventArgs e)
        {

            userControlTemperture.Visible = false;
            userControlHumity.Visible = false;
            userControlLight.Visible = false;
            userControlMap.Visible = true;
        }
    }
}
